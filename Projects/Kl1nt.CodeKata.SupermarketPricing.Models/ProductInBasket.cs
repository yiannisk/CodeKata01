namespace Kl1nt.CodeKata.SupermarketPricing.Models
{
    public class ProductInBasket : ProductOnOffer
    {
        public virtual decimal Quantity { get; set; }

        /// <summary>
        /// Calculates the total price for this basket entry
        /// </summary>
        public virtual decimal TotalPrice
        {
            get { return Quantity * Price; }
        }
    }
}