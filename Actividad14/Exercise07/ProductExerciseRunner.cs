namespace Actividad14.Exercise07
{
    public static class ProductExerciseRunner
    {
        public static void Run()
        {
            var products = new Dictionary<string, Product>();
            Console.Write("¿Cuántos productos desea registrar? ");
            int count = ReadInt();

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\nProducto #{i + 1}");
                Console.Write("Código: ");
                string code = Console.ReadLine()!;
                if (string.IsNullOrWhiteSpace(code) || products.ContainsKey(code))
                {
                    Console.WriteLine("Código inválido o ya registrado. Intente de nuevo.");
                    i--;
                    continue;
                }
                
                Console.Write("Ingrese el nombre del producto: ");
                string name = Console.ReadLine()!;
                
                Console.Write("Ingrese el precio del producto: ");
                decimal price = ReadDecimal();
                
                Console.Write("Stock: "); 
                int stock = ReadInt();
                
                products[code] = new Product(code, name, price, stock);
            }

            Console.WriteLine("Productos registrados: ");
            foreach (var product in products.Values)
            {
                product.ShowInfo();
                Console.WriteLine();
            }

            Console.Write("Ingrese el código de un producto para buscar: ");
            string searchCode = Console.ReadLine()!;
            
            foreach (var product in products)
            {
                if (product.Key.Equals(searchCode))
                {
                    Console.WriteLine("Producto encontrado:");
                    product.Value.ShowInfo();
                    break;
                }
                
                Console.WriteLine("Producto no encontrado.");
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

        private static decimal ReadDecimal()
        {
            while (true)
            {
                if (decimal.TryParse(Console.ReadLine(), out decimal value))
                    return value;
            }
        }
    }
}