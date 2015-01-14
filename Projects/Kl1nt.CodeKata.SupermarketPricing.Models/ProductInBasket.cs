namespace Kl1nt.CodeKata.SupermarketPricing.Models
{
    public class ProductInBasket : ProductOnOffer
    {
        public virtual decimal Quantity { get; set; }
    }
}