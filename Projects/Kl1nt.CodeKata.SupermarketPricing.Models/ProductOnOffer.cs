namespace Kl1nt.CodeKata.SupermarketPricing.Models
{
    public class ProductOnOffer : Product
    {
        public virtual decimal OfferQuantity { get; set; }

        public virtual decimal Price { get; set; }

        public virtual ProductInBasket ToBasket()
        {
            return new ProductInBasket
            {
                Price = Price,
                Name = Name,
                OfferQuantity = OfferQuantity,
                Unit = Unit
            };
        }
    }
}