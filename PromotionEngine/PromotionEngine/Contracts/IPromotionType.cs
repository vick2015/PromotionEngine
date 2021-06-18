using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PromotionEngine.Models;


namespace PromotionEngine.Contracts
{
    public interface IPromotionType
    {
        string PromotionRule { get; }
        double ApplyPromotionRule(Order order);
    }
}
