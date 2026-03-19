namespace Actividad14.Exercise03
{
    public static class EmployeeExerciseRunner
    {
        public static void Run()
        {
            List<Employee> employees = new List<Employee>();

            Console.WriteLine("¿Cuántos empleados desea ingresar?");
            int count = ReadInt();

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\nRegistrando empleado #{i + 1}:");
                Console.Write("Ingrese el nombre del empleado: ");
                string name = Console.ReadLine()!;

                Console.Write("Ingrese el cargo del empleado: ");
                string position = Console.ReadLine()!;
                
                Console.Write("Ingrese el salario del empleado: ");
                double salary = ReadDouble();
                
                Employee employee = new Employee(name, position, salary);
                employees.Add(employee);
            }

            Console.Clear();
            Console.WriteLine("Los empleados registrados son: ");
            foreach (var employee in employees)
            {               
                Console.WriteLine($"Empleado: {employee.Name}");
                Console.WriteLine($"    - Cargo: {employee.Position}");
                Console.WriteLine($"    - Salario mensual: Q{employee.Salary:F2}");
                Console.WriteLine($"    - Salario anual: Q{employee.AnualSalary():F2}");
                Console.WriteLine($"    - Bono anual: Q{employee.CalculateBonus():F2}");
                Console.Write("    - Clasificación salarial: ");
                employee.SalaryClassification();
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