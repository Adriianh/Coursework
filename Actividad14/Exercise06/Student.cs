namespace Actividad14.Exercise06
{
    public class Student(string carnet, string name, string career, double finalGrade)
    {
        private string Carnet { get; } = carnet;
        private string Name { get; } = name;
        private string Career { get; } = career;
        private double FinalGrade { get; } = finalGrade;

        private string IsApproved()
        {
            if (FinalGrade >= 60) { return "Aprobado"; }
            
            return "Reprobado";
        }

        public void ShowInformation()
        {
            Console.WriteLine($"Carnet: {Carnet}");
            Console.WriteLine($"Nombre: {Name}");
            Console.WriteLine($"Carrera: {Career}");
            Console.WriteLine($"Nota final: {FinalGrade}");
            Console.WriteLine($"Estado: {IsApproved()}");
        }
    }
}