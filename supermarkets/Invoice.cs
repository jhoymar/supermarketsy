namespace supermarketsy
{
    internal class Invoice : IPay
{
    public Invoice() { }

    private List<Product> products1 = new List<Product>();
    private object item;

    public decimal GetValueToPay()
    {
        decimal AccumulatorProducts = 0;
        foreach (Product item in products1)
        {
            AccumulatorProducts += item.GetValueToPay();
        }
        return AccumulatorProducts;
    }
    public override string ToString()
    {
        foreach (Product item in products1)
        {
            Console.WriteLine(item.ToString());
        }
        return $"                       ===================" +
               $"\nTOTAL:                 {$"{GetValueToPay():C2}",18}";
    }
    public void AddProduct(Product products)
    {
        products.Add(products);
    }

    }

}
