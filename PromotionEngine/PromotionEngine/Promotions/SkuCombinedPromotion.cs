using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PromotionEngine.Contracts;
using PromotionEngine.Models;
using PromotionEngine.Stores;


namespace PromotionEngine.Promotions
{
    public class SkuCombinedPromotion : IPromotionType
    {
        private readonly string mySku1;
        private readonly string mySku2;
        private readonly double myFixedPrice;
        private readonly IList<Order> myOrders;
        public string PromotionRule { get; }
        
        public SkuCombinedPromotion(string sku1, string sku2, double fixedPrice )
        {
            mySku1 = sku1;
            mySku2 = sku2;
            myFixedPrice = fixedPrice;
            PromotionRule = "buy SKU 1 & SKU 2 for a fixed price";

            myOrders = OrderStores.GetOrders();
        }

        public bool IsPromotionValidOnOrder(Order order)
        {
           

            if (myOrders.Any(a => a.ProductSku == mySku1) && myOrders.Any(a => a.ProductSku == mySku2)
                                                              && (order.ProductSku == mySku1 || order.ProductSku == mySku2))
            {
                return true;
            }

            return false;
        }

        public double ApplyPromotionRule(Order order)
        {
            double finalPromotionPrice = 0;
            string altSku = string.Empty;
            altSku = order.ProductSku == mySku1 ? mySku2 : mySku1;
            var altOrder = myOrders.FirstOrDefault(a => a.ProductSku == altSku);
            if (altOrder.Qty == order.Qty)
            {
                finalPromotionPrice = myFixedPrice * order.Qty;
            }
            else if (altOrder.Qty > order.Qty)
            {
                var promotionPrice = myFixedPrice * order.Qty;
                var remQuantity = (altOrder.Qty - order.Qty);
                var product = ProductStores.GetProductList().FirstOrDefault(a => a.SKU == altOrder.ProductSku);
                var remPrice = remQuantity * product.UnitPrice;

                finalPromotionPrice = remPrice + promotionPrice;
            }
            else
            {
                var promotionPrice = myFixedPrice * altOrder.Qty;
                var remQuantity = (order.Qty - altOrder.Qty);
                var product = ProductStores.GetProductList().FirstOrDefault(a => a.SKU == order.ProductSku);
                var remPrice = remQuantity * product.UnitPrice;

                finalPromotionPrice = remPrice + promotionPrice;
            }


            return finalPromotionPrice / 2;
        }
    }
}
