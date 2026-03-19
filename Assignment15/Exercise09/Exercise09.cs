namespace Assignment15.Exercise09
{
    public static class ExerciseRunner
    {
        public static void Run()
        {            
            double grade = ValidateGrade("Ingrese la calificación del estudiante (0-100): ");
            Console.WriteLine($"\nLa calificación ingresada es: {grade}");
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }

        private static double ValidateGrade(string prompt)
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

                if (!double.TryParse(input, out double grade)) continue;

                if (grade >= 0 && grade <= 100) return grade;
                Console.WriteLine("Calificación inválida. Debe ser un número entre 0 y 100");}
        }
    }
}