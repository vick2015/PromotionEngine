using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PromotionEngine.Models;


namespace PromotionEngine.Stores
{
    public static class OrderStores
    {
        private static readonly List<Order> myOrders = new List<Order>();

        public static void AddOrder(IList<Order> orders)
        {
            myOrders.AddRange(orders);
        }

        public static IList<Order> GetOrders()
        {
            return myOrders;
        }

        public static void Clear()
        {
            myOrders.Clear();
        }
    }
}
