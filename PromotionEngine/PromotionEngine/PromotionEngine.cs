using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PromotionEngine.Contracts;
using PromotionEngine.Models;
using PromotionEngine.Stores;


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
                if (bestPromotionType == null)
                {
                    Product product = ProductStores.GetProductList().FirstOrDefault(a => a.SKU == order.ProductSku);
                    cost = cost + (order.Qty * product.UnitPrice);
                }
                else
                {
                    var promotionCost = bestPromotionType.ApplyPromotionRule(order);
                    cost += promotionCost;
                }

            }

            return cost;
        }
    }
}
