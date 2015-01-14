namespace Kl1nt.CodeKata.SupermarketPricing.Models
{
    public class ProductUnit
    {
        public static readonly ProductUnit Items = new ProductUnit
        {
            Name = "Items",
            Symbol = "p"
        };
        
        public static readonly ProductUnit Kilos = new ProductUnit
        {
            Name = "Kilos",
            Symbol = "kgr"
        };

        public static readonly ProductUnit Litres = new ProductUnit
        {
            Name = "Liters",
            Symbol = "lt"
        };

        public virtual string Name { get; set; }
        public virtual string Symbol { get; set; }
    }
}