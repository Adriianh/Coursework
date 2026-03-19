namespace Assignment15.Exercises
{
    public static class Exercise04Runner
    {
        public static void Run()
        {
            int birthYear = ValidateBirthYear("Ingrese su año de nacimiento (entre 1900 y 2026): ");
            Console.WriteLine($"\nSu año de nacimiento es: {birthYear}");
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
        
        private static int ValidateBirthYear(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine()!;

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("La entrada no puede estar vacía. Intente de nuevo.");
                    continue;
                }

                if (!int.TryParse(input, out int birthYear)) continue;
                
                /*
                 * (birthYear is >= 1900 and <= 2026) equivale a (birthYear >= 1900 && birthYear <= 2026)
                 * pero con una sintaxis más concisa y legible. Es un operador de rango.
                 */
                if (birthYear is >= 1900 and <= 2026)
                    return birthYear;
            }
        }
    }
}