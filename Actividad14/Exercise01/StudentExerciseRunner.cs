namespace Actividad14.Exercise01
{
    public static class StudentExerciseRunner
    {
        public static void Run()
        {
            List<Student> students = new List<Student>();
            Dictionary<Student, double> averages = new Dictionary<Student, double>();

            Console.WriteLine("¿Cuántos estudiantes desea ingresar?");
            int count = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Ingrese el nombre del estudiante: ");
                string name = Console.ReadLine()!;

                Console.WriteLine("Ingrese la nota #1");
                double grade1 = double.Parse(Console.ReadLine()!);

                Console.WriteLine("Ingrese la nota #2");
                double grade2 = double.Parse(Console.ReadLine()!);

                Console.WriteLine("Ingrese la nota #3");
                double grade3 = double.Parse(Console.ReadLine()!);

                Student student = new Student(name, grade1, grade2, grade3);
                students.Add(student);
            }

            Console.WriteLine("Estudiantes registrados: ");
            foreach (var student in students)
            {
                student.ShowInformation();
                double average = student.Average();
                averages.Add(student, average);
            }

            KeyValuePair<Student, double> averageMax = new KeyValuePair<Student, double>();
            foreach (var item in averages)
            {
                if (item.Value > averageMax.Value)
                {
                    averageMax = item;
                }
            }
            if (averageMax.Key != null)
            {
                Console.WriteLine($"El estudiante con el mejor promedio es {averageMax.Key.Name} y su promedio fue de {averageMax.Value}");
            }
        }
    }
}

