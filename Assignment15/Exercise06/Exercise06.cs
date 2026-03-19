namespace Assignment15.Exercise06
{
    public static class ExerciseRunner
    {
        public static void Run()
        {
            DateTime date = ReadValidDate("Ingrese una fecha (formato: dd/MM/yyyy): ");
            
            /*
             * El formato "dd/MM/yyyy" se utiliza para mostrar la fecha en el formato día/mes/año.
             * "dd" representa el día con dos dígitos, "MM" representa el mes con dos dígitos y
             * "yyyy" representa el año con cuatro dígitos.
             *
             * Por ejemplo, si el usuario ingresa "15/08/2023", la salida será "La fecha ingresada es: 15/08/2023".
             * El formato puede variar según el idioma y las preferencias del usuario.
             */
            Console.WriteLine($"\nLa fecha ingresada es: {date:dd/MM/yyyy}");
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }

        private static DateTime ReadValidDate(string prompt)
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

                if (DateTime.TryParse(input, out DateTime date))
                {
                    return date;
                }

                Console.WriteLine("Fecha inválida. Intente de nuevo.");
            }
        }
    }
}