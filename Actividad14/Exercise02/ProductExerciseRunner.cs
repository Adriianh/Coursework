namespace Actividad14.Exercise02
{
    public static class ProductExerciseRunner
    {
        public static void Run()
        {
            List<Product> products = new List<Product>();
            Dictionary<Product, double> prices = new Dictionary<Product, double>();

            Console.WriteLine("¿Cuántos productos desea ingresar?");
            int count = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < count; i++)
            {
                Console.Write("Ingrese el nombre del producto: ");
                string name = Console.ReadLine()!;

                Console.Write("Ingrese el precio del producto: ");
                double price = double.Parse(Console.ReadLine()!);

                Console.Write("Ingrese la cantidad actual del producto: ");
                int quantity = int.Parse(Console.ReadLine()!);

                Product product = new Product(name, price, quantity);
                products.Add(product);
            }

            double totalValue = 0;
            Console.WriteLine("Productos registrados: ");
            foreach (Product product in products)
            {
                Console.WriteLine($"Producto: {product.Name}");
                Console.WriteLine($"    - Precio: {product.Price}");
                Console.WriteLine($"    - Cantidad: {product.Quantity}");

                totalValue += product.TotalValue();
                prices.Add(product, product.Price);
            }
            Console.WriteLine($"El valor total del inventario es: Q{totalValue:F2}");

            KeyValuePair<Product, double> highestPrice = new KeyValuePair<Product, double>();
            foreach (var item in prices)
            {
                if (item.Value > highestPrice.Value)
                {
                    highestPrice = item;
                }
            }
            if (highestPrice.Key != null)
            {
                Console.WriteLine($"El producto con el mayor costo es: {highestPrice.Key.Name} y su precio es {highestPrice.Value}");
            }
        }
    }
}

