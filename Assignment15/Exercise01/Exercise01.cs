namespace Assignment15.Exercise01
{
    public static class ExerciseRunner
    {
        public static void Run()
        {
            int age = ReadValidAge("Ingrese su edad: ");
            Console.WriteLine($"\nSu edad es: {age}");
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }

        private static int ReadValidAge(string prompt)
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
                
                if (int.TryParse(input, out int age) && (age >= 0 && age <= 120))
                {
                    return age;
                }
                Console.WriteLine("Edad inválida. Debe ser un número entre 0 y 120.");
            }
        }
    }
}