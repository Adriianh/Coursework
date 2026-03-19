namespace Actividad14.Exercise01
{
    public static class StudentExerciseRunner
    {
        public static void Run()
        {
            var students = new List<Student>();

            Console.WriteLine("¿Cuántos estudiantes desea ingresar?");
            if (!int.TryParse(Console.ReadLine(), out int count) || count <= 0)
            {
                Console.WriteLine("Cantidad inválida.");
                return;
            }

            for (int i = 0; i < count; i++)
            {
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

            Console.WriteLine("Estudiantes registrados:");
            foreach (var student in students)
            {
                student.ShowInformation();
                Console.WriteLine($"Promedio: {student.Average()}");
            }

            if (students.Count > 0)
            {
                var best = students[0];
                double bestAvg = best.Average();
                foreach (var student in students)
                {
                    double avg = student.Average();
                    if (avg > bestAvg)
                    {
                        best = student;
                        bestAvg = avg;
                    }
                }
                Console.WriteLine($"\nEl estudiante con el mejor promedio es {best.Name} ({bestAvg})");
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
    }
}