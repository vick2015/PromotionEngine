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
    public static class PromotionTypeSelector
    {
        public static IPromotionType GetBestPromotionTypeForOrderedProduct(Order order)
        {
            var activePromotionsList = PromotionStores.GetActivePromotionList();
            foreach (var activePromotionType in activePromotionsList)
            {
                if (activePromotionType.IsPromotionValidOnOrder(order))
                {
                    return activePromotionType;
                }
            }

            return null;
        }
    }
}
