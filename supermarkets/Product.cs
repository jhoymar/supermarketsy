namespace supermarketsy
{
    public abstract class Product
    {

        public int Id { get; set; }

        public string Description { get; set; }

        public List<Product> products = new List<Product>();
        public decimal Price { get; set; }

        public float Tax { get; set; }

        public decimal value { get; set; }

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"   {Id} {Description}" +
                   $"\n\tPrice.......:{$"{Price:C2}",13}" +
                   $"\n\tTax.........:{$"{Tax:P2}",15}";

        }

        internal void Add(Product products)
        {
            throw new NotImplementedException();
        }
    }
}