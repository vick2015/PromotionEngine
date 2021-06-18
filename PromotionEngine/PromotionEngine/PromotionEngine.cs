using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PromotionEngine.Contracts;
using PromotionEngine.Models;


namespace PromotionEngine
{
    public class PromotionEngine : IPromotionEngine
    {
        public double ApplyPromotion(IList<Product> products, IPromotionType promotionType)
        {
            double cost = 0;
            foreach (var product in products)
            {
                var bestPromotionType = PromotionTypeSelector.GetBestPromotionTypeForProduct(product);
                var promotionCost = bestPromotionType.ApplyPromotionRule();
                cost += promotionCost;
            }

            return cost;
        }
    }
}
