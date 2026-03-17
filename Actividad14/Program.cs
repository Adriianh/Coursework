namespace Actividad14
{
    namespace ConsoleApp3
    {
        public class Student
        {
            public string name { get; set; }
            public double grade1 { get; set; }
            public double grade2 { get; set; }
            public double grade3 { get; set; }

            public Student(string name, double grade1, double grade2, double grade3)
            {
                this.name = name;
                this.grade1 = grade1;
                this.grade2 = grade2;
                this.grade3 = grade3;
            }

            public double Average(double grade1, double grade2, double grade3)
            {
                double sum = grade1 + grade2 + grade3;
                double average = sum / 3;
                Console.WriteLine($"El promedio del estudiante es de: {average}");

                return average;
            }

            public static bool IsAproved(double average)
            {
                if (average < 0) { return false; }
                if (average > 60) { return true; }

                return false;
            }

            public void ShowInformation()
            {
                Console.WriteLine($"Nombre: {name}");
                Console.WriteLine($"Nota 1: {grade1}");
                Console.WriteLine($"Nota 2: {grade2}");
                Console.WriteLine($"Nota 3: {grade3}");
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                List<Student> students = new List<Student>();
                Dictionary<Student, double> averages = new Dictionary<Student, double>();

                Console.WriteLine("¿Cuántos estudiantes desea ingresar?");
                int count = int.Parse(Console.ReadLine());

                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("Ingrese el nombre del estudiante: ");
                    string name = Console.ReadLine();

                    Console.WriteLine("Ingrese la nota #1");
                    double grade1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese la nota #2");
                    double grade2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese la nota #3");
                    double grade3 = int.Parse(Console.ReadLine());

                    Student student = new Student(name, grade1, grade2, grade3);
                    students.Add(student);
                }


                Console.WriteLine("Estudiantes registrados: ");
                foreach (var student in students)
                {
                    Console.WriteLine($"Nombre: {student.name}");
                    Console.WriteLine($"   - Nota 1: {student.grade1}");
                    Console.WriteLine($"   - Nota 2: {student.grade2}");
                    Console.WriteLine($"   - Nota 3: {student.grade3}");

                    double average = student.Average(student.grade1, student.grade2, student.grade3);
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
                Console.WriteLine($"El estudiante con el mejor promedio es {averageMax.Key.name} y su promedio fue de {averageMax.Value}");
            }
        }
    }

}