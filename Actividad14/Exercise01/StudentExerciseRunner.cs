namespace Actividad14.Exercise01
{
    public static class StudentExerciseRunner
    {
        public static void Run()
        {
            var students = new List<Student>();

            Console.WriteLine("¿Cuántos estudiantes desea ingresar?");
            int count = ReadInt();
            
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\nRegistrando estudiante #{i + 1}:");
                Console.WriteLine("Ingrese el nombre del estudiante: ");
                string name = Console.ReadLine()!;

                Console.WriteLine("Ingrese la nota #1");
                double grade1 = ReadDouble();

                Console.WriteLine("Ingrese la nota #2");
                double grade2 = ReadDouble();

                Console.WriteLine("Ingrese la nota #3");
                double grade3 = ReadDouble();
                
                students.Add(new Student(name, grade1, grade2, grade3));
            }

            Console.Clear();
            Console.WriteLine("Estudiantes registrados:");
            foreach (var student in students)
            {
                student.ShowInformation();
            }

            if (students.Count > 0)
            {
                var best = students[0];
                double bestAvg = best.Average();
                foreach (var student in students)
                {
                    double avg = student.Average();
                    if (!(avg > bestAvg)) continue;
                    
                    best = student;
                    bestAvg = avg;
                }
                Console.WriteLine($"\nEl estudiante con el mejor promedio es {best.Name} ({bestAvg:F2})");
            }
            else
            {
                Console.WriteLine("No hay estudiantes registrados.");
            }
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
            }
        }
    }
}