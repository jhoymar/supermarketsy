using System.Collections;

namespace supermarket
{
    internal class ComposedProduct : Product
    {

        public float Discount { get; set; }

        private string asisten { get; set; }

        public decimal value { get; set; }

        public ICollection? Products { get; set; }

        public override decimal GetValueToPay()
        {

            foreach (Product product01 in Products)
            {
                float desc = 0;
                decimal assi;
                assi = product01.GetValueToPay();
                desc = (float)assi * Discount;
                value += assi - (decimal)desc;
            }
            return value;


        }

        public override string ToString()
        {
            foreach (Product productDiscount in Products)
            {
                asisten += productDiscount.Description + ",";
            }


            return $"{base.ToString()}" +
                  $"\n\tDiscount....:{$"{Discount:P2}",13}" +
                  $"\n\tProducts....:{$"{asisten}",13}" +
                  $"\n\tValue.......: {$"{GetValueToPay():C2}",13}";
        }
    }
}


