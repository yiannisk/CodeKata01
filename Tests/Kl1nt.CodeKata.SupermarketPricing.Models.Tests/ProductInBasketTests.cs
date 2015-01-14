using NUnit.Framework;

namespace Kl1nt.CodeKata.SupermarketPricing.Models.Tests
{
    [TestFixture]
    public class ProductInBasketTests
    {
        [Test]
        public void TestTotalPriceHappyPath()
        {
            var basketProduct = new ProductInBasket
            {
                Price = 1.2m,
                Quantity = 2.3m
            };

            Assert.AreEqual(2.76m, basketProduct.TotalPrice);
        }

        [Test]
        public void TestTotalPriceWithQuantityMissing()
        {
            var basketProduct = new ProductInBasket { Price = 25m };
            Assert.AreEqual(0, basketProduct.TotalPrice);
        }

        [Test]
        public void TestTotalPriceWithPriceMissing()
        {
            var basketProduct = new ProductInBasket { Quantity = 1m };
            Assert.AreEqual(0, basketProduct.TotalPrice);
        }
    }
}