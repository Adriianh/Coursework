namespace Assignment15.Exercise02
{
    public static class ExerciseRunner
    {
        public static void Run()
        {
            Console.Clear();
            decimal amount = ReadPositiveDecimal("Ingrese el precio de su producto: ");
            
            Console.WriteLine($"\nPrecio registrado: {amount:C}");
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }

        private static decimal ReadPositiveDecimal(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine()!;
                
                /* Prevención de error: la entrada (input) no debe estar vacía. */
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Entrada vacía. Intente de nuevo.");
                    continue;
                }
                
                if (decimal.TryParse(input, out decimal value) && (value > 0))
                {
                    return value;
                }
                Console.WriteLine("Cantidad inválida. Debe ser un número mayor que 0.");
            }
        }
    }
}