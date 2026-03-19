namespace Actividad14.Exercise09;

public class Course(string name, int credits, double averageGrade)
{
    public string Name { get; } = name;
    private int Credits { get; } = credits;
    public double AverageGrade { get; } = averageGrade;

    private string GetPerformance()
    {
        switch (AverageGrade)
        {
            case >= 90:
                return "Excelente";
            case >= 70:
                return "Aceptable";
            default:
                return "Bajo";
        }
    }

    public void ShowInfo()
    {
        Console.WriteLine($"  - Nombre: {Name}");
        Console.WriteLine($"  - Créditos: {Credits}");
        Console.WriteLine($"  - Nota promedio: {AverageGrade:F2}");
        Console.WriteLine($"  - Rendimiento: {GetPerformance()}");
    }
}