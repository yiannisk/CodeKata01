using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kl1nt.CodeKata.SupermarketPricing.Models.Tests
{
    public class ProductOnOfferTests
    {
        public void TestModelling()
        {
            // Simple 1 to 1 pricing
            var tomatoSoup = new ProductOnOffer
            {
                Name = "Tomato Soup",
                Quantity = 1,
                Price = 0.65m
            };

            // Three for a buck
            var spaghettiOfferPack = new ProductOnOffer
            {
                Name = "Spaghetti 3x Pack", 
                Quantity = 3,
                Price = 1m
            };

            // 2 + 1 free
            var tomatoSoupOfferPack = new ProductOnOffer
            {
                Name = "Tomato Soup 2 + 1 free pack",
                Quantity = 3,
                Price = 1.3m
            };

            // TODO: Support the following additional cases
            //  - Free product when buying another product
            //  - Does not support arbitrary units and fractional purchases,
            //    ie. 650g ham.
        }
    }
}
