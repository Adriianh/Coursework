namespace Actividad14.Exercise03
{
    public static class EmployeeExerciseRunner
    {
        public static void Run()
        {
            List<Employee> employees = new List<Employee>();

            Console.WriteLine("¿Cuántos empleados desea ingresar?");
            int count = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < count; i++)
            {
                Console.Write("Ingrese el nombre del empleado: ");
                string name = Console.ReadLine()!;

                Console.WriteLine("Ingrese el cargo del empleado: ");
                string position = Console.ReadLine()!;
                
                Console.WriteLine("Ingrese el salario del empleado: ");
                double salary = double.Parse(Console.ReadLine()!);
                
                Employee employee = new Employee(name, position, salary);
                employees.Add(employee);
            }

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
    }
}