using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PromotionEngine.Models;
using PromotionEngine.Promotions;
using PromotionEngine.Stores;


namespace PromotionEngine.Test
{
    public class PromotionEngineTests
    {
        private PromotionEngine myPromotionEngine;

        [SetUp]
        public void SetUp()
        {
            myPromotionEngine = new PromotionEngine();
            AddProducts();
            AddPromotions();
        }

        [TearDown]

        public void TearDown()
        {
            myPromotionEngine = null;
        }

        [Test]

        public void ApplyPromotion_WithIndividualSku_DiscountedTotalShouldBeReturned()
        {
            var orders = new List<Order> {new Order(5, "A"), new Order(5, "B"), new Order(1, "C")};
            double promotionPrice = myPromotionEngine.ApplyPromotion(orders);
            Assert.AreEqual(370,promotionPrice);
        }

        [Test]
        public void ApplyPromotion_WithNoPromotionApplied_ActualTotalShouldBeReturned()
        {
            var orders = new List<Order> { new Order(1, "A"), new Order(1, "B"), new Order(1, "C") };
            double promotionPrice = myPromotionEngine.ApplyPromotion(orders);
            Assert.AreEqual(100, promotionPrice);
        }

        [Test]
        public void ApplyPromotion_WithMultiplePromotionTypes_DiscountedTotalShouldBeReturned()
        {

        }

        private void AddProducts()
        {
            ProductStores.AddProduct(new Product("A", 50));
            ProductStores.AddProduct(new Product("B", 30));
            ProductStores.AddProduct(new Product("C", 20));
            ProductStores.AddProduct(new Product("D", 15));
        }

        private void AddPromotions()
        {
            PromotionStores.AddPromotion(new SkuQuantityPromotion(3,"A",130));
            PromotionStores.AddPromotion(new SkuQuantityPromotion(2, "B", 45));
            PromotionStores.AddPromotion(new SkuCombinedPromotion("C", "D", 30));
        }

    }
}
