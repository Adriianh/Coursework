namespace Assignment15.Exercises
{
    public static class Exercise10Runner
    {
        public static void Run()
        {
            Console.Clear();
            int productCount = ReadPositiveInt("Ingrese la cantidad de productos a comprar: ");
            var products = ReadProductsList(productCount);

            Console.WriteLine($"\nCantidad de productos ingresados: {products.Count}");
            foreach (var product in products)
            {
                Console.WriteLine($"- {product.Name}: Q{product.Price}");
            }
            
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }

        /*
         * Lee una lista de productos con su nombre y precio.
         * El método recibe la cantidad de productos a ingresar y devuelve
         * una lista de tuplas con el nombre y precio de cada producto.
         */
        private static List<(string Name, decimal Price)> ReadProductsList(int productCount)
        {
            var products = new List<(string Name, decimal Price)>();
            for (int i = 1; i <= productCount; i++)
            {
                Console.Clear(); 
                Console.WriteLine($"\nProducto #{i}");
                string name = ReadNonEmpty("Ingrese el nombre del producto: ");
                decimal price = ReadPositiveDecimal("Ingrese el precio del producto: ");
                
                products.Add((name, price));
            }
            
            return products;
        }

        private static string ReadNonEmpty(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine()!;
                
                if (!string.IsNullOrWhiteSpace(input)) return input;
                Console.WriteLine("El valor no puede estar vacío.");
            }
        }

        private static int ReadPositiveInt(string prompt)
        {
            while (true)
            {
                string input = ReadNonEmpty(prompt);
                
                if (int.TryParse(input, out int value) && value > 0) return value;
                Console.WriteLine("Valor inválido. Debe ser un número entero positivo.");
            }
        }

        private static decimal ReadPositiveDecimal(string prompt)
        {
            while (true)
            {
                string input = ReadNonEmpty(prompt);
                
                if (decimal.TryParse(input, out decimal value) && value > 0) return value;
                Console.WriteLine("Valor inválido. Debe ser un número decimal positivo.");
            }
        }
    }
}