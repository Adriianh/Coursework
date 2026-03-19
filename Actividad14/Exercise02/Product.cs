namespace Actividad14.Exercise02
{
    public class Product(string name, double price, int quantity)
    {
        public string Name { get; } = name;
        public double Price { get; } = price;
        public int Quantity { get; } = quantity;

        public double TotalValue()
        {
            return Price * Quantity;
        }

        public void Stock()
        {
            if (Quantity == 0)
            {
                Console.WriteLine("Sin existencias.");
            }
            else if (Quantity > 0 && Quantity < 10)
            {
                Console.WriteLine("Stock bajo.");
            }
            else
            {
                Console.WriteLine("Stock suficiente.");
            }
        }
    }
}

