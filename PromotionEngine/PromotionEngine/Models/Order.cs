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
        public string ProductSku { get; }

        public Order(int qty , string productSku)
        {
            Qty = qty;
            ProductSku = productSku;
        }
    }
}
