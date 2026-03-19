namespace Actividad14.Exercise02
{
    public static class ProductExerciseRunner
    {
        public static void Run()
        {
            List<Product> products = new List<Product>();

            Console.WriteLine("¿Cuántos productos desea ingresar?");
            if (!int.TryParse(Console.ReadLine(), out int count) || count <= 0)
            {
                Console.WriteLine("Cantidad inválida.");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                Console.Write("Ingrese el nombre del producto: ");
                string name = Console.ReadLine()!;

                Console.Write("Ingrese el precio del producto: ");
                double price = ReadDouble();

                Console.Write("Ingrese la cantidad actual del producto: ");
                int quantity = ReadInt();

                products.Add(new Product(name, price, quantity));
            }

            double totalValue = 0;
            Console.WriteLine("Productos registrados:");
            foreach (var product in products)
            {
                Console.WriteLine($"Producto: {product.Name}");
                Console.WriteLine($"    - Precio: {product.Price}");
                Console.WriteLine($"    - Cantidad: {product.Quantity}");
                totalValue += product.TotalValue();
            }
            Console.WriteLine($"El valor total del inventario es: Q{totalValue:F2}");

            if (products.Count > 0)
            {
                var mostExpensive = products[0];
                foreach (var product in products)
                {
                    if (product.Price > mostExpensive.Price)
                    {
                        mostExpensive = product;
                    }
                }
                Console.WriteLine($"El producto con el mayor costo es: {mostExpensive.Name} y su precio es {mostExpensive.Price}");
            }
            else
            {
                Console.WriteLine("No hay productos registrados.");
            }
        }

        private static double ReadDouble()
        {
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out double value))
                    return value;
                Console.WriteLine("Valor inválido, intente de nuevo:");
            }
        }

        private static int ReadInt()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int value))
                    return value;
                Console.WriteLine("Valor inválido, intente de nuevo:");
            }
        }
    }
}
