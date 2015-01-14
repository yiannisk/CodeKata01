using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kl1nt.CodeKata.SupermarketPricing.Models.Tests
{
    /// <summary>
    /// Not executable tests that demonstrate different 
    /// product specification scenarios.
    /// </summary>
    public class ModellingTests
    {
        public void DifferentProductOnOfferSpecs()
        {
            // Simple 1 to 1 pricing
            var tomatoSoup = new ProductOnOffer
            {
                Name = "Tomato Soup",
                OfferQuantity = 1m,
                Price = 0.65m,
                Unit = ProductUnit.Items
            };

            // Three for a buck
            var spaghettiOfferPack = new ProductOnOffer
            {
                Name = "Spaghetti 3x Pack", 
                OfferQuantity = 3,
                Price = 1m,
                Unit = ProductUnit.Items
            };

            // 2 + 1 free
            var tomatoSoupOfferPack = new ProductOnOffer
            {
                Name = "Tomato Soup 2 + 1 free pack",
                OfferQuantity = 3,
                Price = 1.3m,
                Unit = ProductUnit.Items
            };

            // TODO: Support the following additional cases
            //  - Free product when buying another product
            //  - Multiple units and price per unit

            // TODO: Shopping basket and pricing
        }

        public void DifferentProductInBasketSpecs()
        {
            // Fractional purchases
            var fetaCheese = new ProductOnOffer
            {
                Name = "Feta",
                Price = 8.9m,
                OfferQuantity = 1,
                Unit = ProductUnit.Kilos
            };

            var halfAKiloOfFeta = fetaCheese.ToBasket(0.5m);
        }
    }
}
