using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PromotionEngine.Models;


namespace PromotionEngine.Promotions
{
    public class SkuCombinedPromotion
    {
        private readonly string mySku1;
        private readonly string mySku2;
        private readonly double myFixedPrice;
        public string PromotionRule { get; }

        public SkuCombinedPromotion(string sku1, string sku2, double fixedPrice)
        {
            mySku1 = sku1;
            mySku2 = sku2;
            myFixedPrice = fixedPrice;
            PromotionRule = "buy SKU 1 & SKU 2 for a fixed price";
        }

        public double ApplyPromotionRule(Order order)
        {
            return myFixedPrice;
        }
    }
}
