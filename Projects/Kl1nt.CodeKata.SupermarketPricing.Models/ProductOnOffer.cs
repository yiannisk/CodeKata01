namespace Kl1nt.CodeKata.SupermarketPricing.Models
{
    public class ProductOnOffer : Product
    {
        public virtual int Quantity { get; set; }
        public virtual decimal Price { get; set; }
    }
}