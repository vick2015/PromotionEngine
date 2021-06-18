using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Test
{
    public class PromotionEngineTests
    {
        private PromotionEngine myPromotionEngine;

        [SetUp]
        public void SetUp()
        {
            myPromotionEngine = new PromotionEngine();
        }

        [TearDown]

        public void TearDown()
        {
            myPromotionEngine = null;
        }

        [Test]

        public void ApplyPromotion_WithSingleUnitOfSku_TotalShouldBeReturned()
        {

        }

        [Test]
        public void ApplyPromotion_WIthPromotionTypes_DiscountedTotalShouldBeReturned()
        {

        }

        [Test]
        public void ApplyPromotion_WithMultiplePromotionTypes_DiscountedTotalShouldBeReturned()
        {

        }

    }
}
