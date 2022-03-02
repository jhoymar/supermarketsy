namespace supermarketsy
{
    internal class FixedPriceProduct : Product

{
    public override decimal GetValueToPay()
    {
        return Price + (Price * (decimal)Tax);
    }



    public override string ToString()
    {
        return $"{base.ToString()}" +
            $"\n\tValue.......:{$"{GetValueToPay():C2}",13}";
    }
}
}

