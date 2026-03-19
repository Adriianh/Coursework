namespace Assignment15.Exercises
{
    public static class Exercise07Runner
    {
        public static void Run()
        {
            decimal salary = ValidateSalary("Ingrese su salario mensual: ");
            Console.WriteLine($"\nSu salario mensual es: {salary:C}");
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }

        private static decimal ValidateSalary(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine()!;
                
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Entrada vacía. Intente de nuevo.");
                    continue;
                }
                
                if (decimal.TryParse(input, out decimal salary) && (salary >= 0))
                {
                    return salary;
                }
                Console.WriteLine("Salario inválido. Debe ser un número mayor que 0.");
            }
        }
    }
}