namespace Actividad14.Exercise06
{
    public static class StudentExerciseRunner
    {
        public static void Run()
        {
            var students = new Dictionary<string, Student>();

            Console.WriteLine("¿Cuántos estudiantes desea registrar?");
            int count = ReadInt();
            
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\nEstudiante #{i + 1}");
                string carnet;
                do
                {
                    Console.Write("Ingrese el carnet: ");
                    carnet = Console.ReadLine() ?? "";
                    if (students.ContainsKey(carnet))
                        Console.WriteLine("Carnet ya registrado, ingrese uno diferente.");
                } while (string.IsNullOrWhiteSpace(carnet) || students.ContainsKey(carnet));

                Console.Write("Ingrese el nombre: ");
                string name = Console.ReadLine() ?? "";

                Console.Write("Ingrese la carrera: ");
                string career = Console.ReadLine() ?? "";

                Console.Write("Ingrese la nota final: ");
                double finalGrade = ReadDouble();

                students[carnet] = new Student(carnet, name, career, finalGrade);
            }

            Console.WriteLine("\nRegistros de estudiantes:");
            foreach (var student in students.Values)
            {
                student.ShowInformation();
                Console.WriteLine();
            }

            Console.WriteLine("\nBuscar estudiante por carnet");
            Console.Write("Ingrese el carnet a buscar: ");
            string searchCarnet = Console.ReadLine() ?? ""; 
            
            foreach (var student in students)
            {
                if (student.Key.Equals(searchCarnet))
                {
                    Console.WriteLine("Estudiante encontrado:");
                    student.Value.ShowInformation();
                    return;
                }

                Console.WriteLine("Estudiante no encontrado.");
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
                Console.WriteLine("Valor inválido, intente de nuevo:");
            }
        }
    }
}