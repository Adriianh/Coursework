namespace Assignment16
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Product> products = new Dictionary<int, Product>();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("---- Menú de Ejercicios ----");
                Console.WriteLine("1. Añadir producto");
                Console.WriteLine("2. Modificar producto");
                Console.WriteLine("3. Eliminar producto");
                Console.WriteLine("4. Buscar un producto");
                Console.WriteLine("5. Listar todos los productos");
                Console.WriteLine("0. Salir");
                Console.WriteLine("");


                int choice = InputNonEmptyInt("Seleccione una opción: ");

                if (choice == 0) break;
                switch (choice)
                {
                    case 1:
                        AddProduct(products);
                        break;
                    case 2:
                        ModifyProduct(products);
                        break;
                    case 3:
                        RemoveProduct(products);
                        break;
                    case 4:
                        SearchProduct(products);
                        break;
                    case 5:
                        ListAllProducts(products);
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void AddProduct(Dictionary<int, Product> products)
        {
            int id = InputNonEmptyInt("Ingrese el código del producto: ");
            string name = InputNonEmpty("Ingrese el nombre del producto: ");
            decimal price = InputNonEmptyDecimal("Ingrese el precio del producto: ");

            Product product = new Product();
            product.Id = id;
            product.Name = name;
            product.Price = price;

            products.Add(id, product);
            Console.WriteLine($"Se agregó el producto {product.Name} con el ID {product.Id}");
            Console.WriteLine("Presione alguna tecla para continuar...");
            Console.ReadKey(true);
        }

        public static void ModifyProduct(Dictionary<int, Product> products)
        {
            while (true)
            {
                int id = InputNonEmptyInt("Ingrese el código del producto: ");

                if (products.TryGetValue(id, out Product product))
                {
                    Console.WriteLine("¿Desea modificar el nombre del producto? (s/n)");
                    if (Console.ReadKey(true).Key.Equals(ConsoleKey.S))
                    {
                        string name = InputNonEmpty("Ingrese el nombre del producto: ");
                        product.Name = name;
                    }

                    Console.WriteLine("¿Desea modificar el precio del producto? (s/n)");
                    if (Console.ReadKey(true).Key.Equals(ConsoleKey.S))
                    {
                        decimal price = InputNonEmptyDecimal("Ingrese el precio del producto: ");
                        product.Price = price;
                    }

                    return;
                }

                Console.WriteLine($"El producto con el código {id} no existe.");
                Console.WriteLine("¿Desea intentar nuevamente? (s/n)");
                if (Console.ReadKey(true).Equals(ConsoleKey.S))
                {
                    continue;
                }
                break;
            }
        }

        private static void RemoveProduct(Dictionary<int, Product> products)
        {
            while (true)
            {
                int id = InputNonEmptyInt("Ingrese el código del producto: ");

                if (products.TryGetValue(id, out Product product))
                {
                    Console.WriteLine($"¿Desea eliminar el producto {product.Name} con ID {product.Id}? (s/n)");
                    if (Console.ReadKey(true).Key.Equals(ConsoleKey.S))
                    {
                        products.Remove(id);
                        break;
                    }

                    Console.WriteLine("El producto no existe, intente nuevamente.");
                    Console.WriteLine("¿Desea intentar nuevamente? (s/n)");
                    if (Console.ReadKey(true).Key.Equals(ConsoleKey.S))
                    {
                        continue;
                    }
                    break;
                }
            }
        }
        private static void SearchProduct(Dictionary<int, Product> products)
        {
            while (true)
            {
                int id = InputNonEmptyInt("Ingrese el código del producto: ");

                if (products.TryGetValue(id, out Product product))
                {
                    Console.WriteLine("Producto: ");
                    Console.WriteLine($"  - Id: {product.Id}");
                    Console.WriteLine($"  - Nombre: {product.Name}");
                    Console.WriteLine($"  - Precio: {product.Price}");
                    Console.WriteLine("");
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey(true);
                    break;
                }

                Console.WriteLine("El producto no existe, intente nuevamente.");
                Console.WriteLine("¿Desea intentar nuevamente? (s/n)");
                if (Console.ReadKey(true).Key.Equals(ConsoleKey.S))
                {
                    continue;
                }
                break;
            }
        }

        private static void ListAllProducts(Dictionary<int, Product> products)
        {
            if (products == null)
            {
                Console.WriteLine("La lista de productos está vacía.");
                return;
            }

            foreach (var product in products)
            {
                Console.WriteLine("Producto: ");
                Console.WriteLine($"  - Id: {product.Key}");
                Console.WriteLine($"  - Nombre: {product.Value.Name}");
                Console.WriteLine($"  - Precio: {product.Value.Price}");
            }

            Console.WriteLine("Presione alguna tecla para continuar...");
            Console.ReadKey(true);
        }

        private static string InputNonEmpty(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine()!;

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("La entrada no puede estar vacía.");
                    continue;
                }

                return input;
            }
        }

        private static int InputNonEmptyInt(string prompt)
        {
            while (true)
            {
                string input = InputNonEmpty(prompt);

                if (!int.TryParse(input, out int value))
                {
                    Console.WriteLine("Entrada inválida, debe ser de tipo entero.");
                    Console.WriteLine("Presione alguna tecla para continuar...");
                    Console.ReadKey(true);
                    continue;
                }

                return value;
            }
        }

        private static decimal InputNonEmptyDecimal(string prompt)
        {
            while (true)
            {
                string input = InputNonEmpty(prompt);

                if (!decimal.TryParse(input, out decimal value))
                {
                    Console.WriteLine("Entrada inválida, debe ser de tipo decimal.");
                    Console.WriteLine("Presione alguna tecla para continuar...");
                    Console.ReadKey(true);
                    continue;
                }

                return value;
            }
        }
    }
}