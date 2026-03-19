namespace Actividad14.Exercise09;

public class CourseExerciseRunner
{
    public static void Run()
    {
        var courses = new List<Course>();
        Console.Write("¿Cuántos cursos desea registrar? ");
        int count = ReadInt();
        
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"\nCurso #{i + 1}");
            Console.Write("Nombre del curso: ");
            string name = Console.ReadLine()!;
            
            Console.Write("Créditos: ");
            int credits = ReadInt();
            
            Console.Write("Nota promedio: ");
            double avg = ReadDouble();
            while (avg < 0 || avg > 100)
            {
                Console.WriteLine("Nota inválida, intente de nuevo:");
                avg = ReadDouble();
            }
            
            courses.Add(new Course(name, credits, avg));
        }

        Console.WriteLine("\n--- Cursos registrados ---");
        foreach (var course in courses)
        {
            course.ShowInfo();
            Console.WriteLine();
        }

        if (courses.Count > 0)
        {
            var best = courses[0];
            foreach (var course in courses)
            {
                if (course.AverageGrade > best.AverageGrade)
                    best = course;
            }
            Console.WriteLine($"Curso con mejor promedio: {best.Name} ({best.AverageGrade:F2})");
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

    private static double ReadDouble()
    {
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out double value))
                return value;
        }
    }
}