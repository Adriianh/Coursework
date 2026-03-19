namespace Assignment15.Exercise03
{
    public static class ExerciseRunner
    {
        public static void Run()
        {
            int studentsAmount = ValidateStudentsAmount("¿Cuántos estudiantes hay en el curso? ");
            Console.WriteLine($"\nHay {studentsAmount} estudiantes en el curso.");
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }

        private static int ValidateStudentsAmount(string prompt)
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

                if (int.TryParse(Console.ReadLine(), out int amount) && (amount > 0))
                {
                    return amount;
                }
                Console.WriteLine("Dato inválida. Debe ser un número mayor que 0.");    
            }
        }
    }
}