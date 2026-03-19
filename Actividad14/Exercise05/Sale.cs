namespace Actividad14.Exercise05
{
    public class Sale(string productName, double price, int quantity)
    {
        public string ProductName { get; } = productName;
        public double Price { get; } = price;
        public int Quantity { get; } = quantity;
        
        public double Subtotal()
        {
            return Price * Quantity;
        }

        public double Discount()
        {
            double subtotal = Subtotal();
            if (subtotal >= 100)
            {
                return subtotal * 0.1;
            }            
            return 0;
        }
        
        public double Total()
        {
            return Subtotal() - Discount();
        }
    }
}