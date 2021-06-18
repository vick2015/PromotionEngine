using PromotionEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PromotionEngine.Contracts
{
    interface IPromotionEngine
    {
        double ApplyPromotion(IList<Order> orders);
    } 
}
