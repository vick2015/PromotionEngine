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
    public class SkuQuantityPromotion : IPromotionType
    {
        private readonly int myNoOfUnits;
        private readonly string mySku;
        private readonly double myFixedPrice;
        public string PromotionRule { get; }

        public SkuQuantityPromotion(int noOfUnits , string sku , double fixedPrice)
        {
            myNoOfUnits = noOfUnits;
            mySku = sku;
            myFixedPrice = fixedPrice;
            PromotionRule = "buy 'n' items of a SKU for a fixed price";
        }

        public bool IsPromotionValidOnOrder(Order order)
        {
            if (order.ProductSku != mySku)
            {
                return false;
            }

            return order.Qty >= myNoOfUnits;
        }

        public double ApplyPromotionRule(Order order)
        {
            int quantityToApplyPromotionOn = order.Qty/myNoOfUnits;
            int remainingQty = order.Qty % myNoOfUnits;
            var product = ProductStores.GetProductList().FirstOrDefault(a => a.SKU == order.ProductSku);

            if (product == null)
            {
                throw  new InvalidOperationException("Product is null");
            }

            var remainingPrice = remainingQty * (product.UnitPrice);

            var promotionPrice = remainingPrice + myFixedPrice*quantityToApplyPromotionOn;

            return promotionPrice;
        }

       
    }
}
