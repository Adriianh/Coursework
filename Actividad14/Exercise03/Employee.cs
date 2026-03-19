namespace Actividad14.Exercise03
{
    public class Employee(string name, string position, double salary)
    {
        public string Name { get; } = name;
        public string Position { get; } = position;
        public double Salary { get; } = salary;

        public double AnualSalary()
        {
            return Salary * 12;
        }
        
        public double CalculateBonus()
        {
            return Salary * 0.1;
        }

        public void SalaryClassification()
        {
            if (Salary < 4000)
            {
                Console.WriteLine("Salario bajo");
            }
            else if (Salary < 10000)
            {
                Console.WriteLine("Salario medio");
            }
            else
            {
                Console.WriteLine("Salario alto");
            }
        }
    }
}