using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PromotionEngine.Models;


namespace PromotionEngine.Stores
{
    public static class ProductStores
    {
        private static readonly List<Product> myProductList = new List<Product>();

        public static void AddProduct(Product product)
        {
            myProductList.Add(product);
        }

        public static IReadOnlyCollection<Product> GetProductList()
        {
            return myProductList;
        }

        public static void Clear()
        {
            myProductList.Clear();
        }
    }
}
