namespace Actividad14.Exercise05
{
    public static class SaleExerciseRunner
    {
        public static void Run()
        {
            var sales = new List<Sale>();

            Console.WriteLine("¿Cuántas ventas desea registrar?");
            int count = ReadInt();

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\nVenta #{i + 1}");
                Console.Write("Ingrese el nombre del producto: ");
                string productName = Console.ReadLine()!;

                Console.Write("Ingrese el precio del producto: ");
                double price = ReadDouble();

                Console.Write("Ingrese la cantidad: ");
                int quantity = ReadInt();

                sales.Add(new Sale(productName, price, quantity));
            }

            double totalSales = 0;
            Console.WriteLine("\nVentas registradas:");
            foreach (var sale in sales)
            {
                Console.WriteLine($"Producto: {sale.ProductName}");
                Console.WriteLine($"  - Precio: {sale.Price}");
                Console.WriteLine($"  - Cantidad: {sale.Quantity}");
                Console.WriteLine($"  - Subtotal: {sale.Subtotal():F2}");
                Console.WriteLine($"  - Descuento: {sale.Discount():F2}");
                Console.WriteLine($"  - Total: {sale.Total():F2}");
                totalSales += sale.Total();
            }
            Console.WriteLine($"\nTotal general vendido: {totalSales:F2}");
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

