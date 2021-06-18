using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PromotionEngine.Contracts;


namespace PromotionEngine.Stores
{
    public static class PromotionStores
    {
        private static readonly List<IPromotionType> myPromotionTypes = new List<IPromotionType>();

        public static void AddProduct(IPromotionType promotion)
        {
            myPromotionTypes.Add(promotion);
        }

        public static IReadOnlyCollection<IPromotionType> GetActivePromotionList(IPromotionType promotion)
        {
            return myPromotionTypes;
        }
    }
}
