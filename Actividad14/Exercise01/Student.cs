namespace Actividad14.Exercise01
{
    public class Student(string name, double grade1, double grade2, double grade3)
    {
        public string Name { get; } = name;
        private double Grade1 { get; } = grade1;
        private double Grade2 { get; } = grade2;
        private double Grade3 { get; } = grade3;

        public double Average()
        {
            double sum = Grade1 + Grade2 + Grade3;
            double average = sum / 3;
            return average;
        }

        public static bool IsApproved(double average)
        {
            if (average < 0) { return false; }
            if (average > 60) { return true; }
            return false;
        }

        public void ShowInformation()
        {
            Console.WriteLine($"Nombre: {Name}");
            Console.WriteLine($"  - Nota 1: {Grade1}");
            Console.WriteLine($"  - Nota 2: {Grade2}");
            Console.WriteLine($"  - Nota 3: {Grade3}");
        }
    }
}

