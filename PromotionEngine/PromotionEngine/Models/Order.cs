using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Models
{
    public class Order
    {
        public int Qty { get; }
        public Product Product { get; }

        public Order(int qty , Product product)
        {
            Qty = qty;
            Product = product;
        }
    }
}
