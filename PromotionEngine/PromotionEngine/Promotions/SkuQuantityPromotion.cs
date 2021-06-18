using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PromotionEngine.Contracts;
using PromotionEngine.Models;


namespace PromotionEngine.Promotions
{
    class SkuQuantityPromotion : IPromotionType
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

        public double ApplyPromotionRule(Order order)
        {
            int remainingQty = myNoOfUnits - order.Qty;
            double remainingPrice = remainingQty * (order.Product.UnitPrice);

            double promotionPrice = remainingPrice + myFixedPrice;

            return promotionPrice;
        }
    }
}
