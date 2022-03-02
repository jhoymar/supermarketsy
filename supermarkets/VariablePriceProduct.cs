using supermarketsy;

namespace supermarket
{
    internal class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }
        public double Quantity { get; set; }

        private string asistent { get; set; }


        public override decimal GetValueToPay()
        {
            decimal Assistant;
            Assistant = (Price * (decimal)Quantity);
            return (Price * (decimal)Quantity) * (decimal)Tax;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
              $"\n\tMeasurement.:{$"{Measurement}",13}" +
              $"\n\tQuantity....:{$"{Quantity:N2}",13}" +
              $"\n\tValue.......:{$"{GetValueToPay():C2}",13}";

        }
    }
}