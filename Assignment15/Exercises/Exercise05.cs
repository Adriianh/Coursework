namespace Assignment15.Exercises
{
    public static class Exercise05Runner
    {
        public static void Run()
        {
            string parity = ResolveNumberParity("Ingrese un número: ");
            Console.WriteLine($"\nSu número es {parity}.");
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }

        private static string ResolveNumberParity(string prompt)
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
                
                if (!int.TryParse(input, out int number)) continue;
                
                /*
                 * Operador ternario
                 * 
                 * `(number % 2 == 0) ? "Par" : "Impar"` es una expresión condicional que evalúa si el número es par o impar.
                 * Si el número es par (es decir, el residuo de dividirlo por 2 es 0), devuelve "Par". De lo contrario, devuelve "Impar".
                 */
                return number % 2 == 0 ? "Par" : "Impar";
            }
        }
    }
}