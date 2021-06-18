using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Models
{
    public class Product
    {
        public string SKU { get; }

        public double UnitPrice { get; }

        public Product(string sku  , double unitPrice)
        {
            SKU = sku;
            UnitPrice = unitPrice;
        }
    }
}
