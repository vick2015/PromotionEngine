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
            throw new NotImplementedException();
        }
    }
}
