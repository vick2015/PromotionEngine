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
        public double ApplyPromotion(IList<Order> orders)
        {
            double cost = 0;
            foreach (var order in orders)
            {
                var bestPromotionType = PromotionTypeSelector.GetBestPromotionTypeForOrderedProduct(order);
                var promotionCost = bestPromotionType.ApplyPromotionRule(order);
                cost += promotionCost;
            }

            return cost;
        }
    }
}
