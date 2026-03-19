namespace Assignment15.Exercises
{
    public static class Exercise08Runner
    {
        public static void Run()
        {            
            double result = GetSquareRoot("Ingrese un número para calcular su raíz cuadrada: ");
            Console.WriteLine($"\nLa raíz cuadrada es: {result}");
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }

        private static double GetSquareRoot(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine()!;

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Entrada vacía. Intente de nuevo.");
                    continue;
                }

                if (!double.TryParse(input, out double value)) continue;
                
                if (value >= 0) return Math.Sqrt(value);
                Console.WriteLine("Número inválido. Debe ser un número mayor o igual a 0.");
            }
        }
    }
}