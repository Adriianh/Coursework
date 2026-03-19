using Assignment15.Exercises;

namespace Assignment15
{
    internal abstract class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Menú de Ejercicios ===");
                for (var i = 0; i < 10; i++)
                {
                    Console.WriteLine($"{i+1}. Ejercicio #{i+1}");
                }
                Console.WriteLine("X. Salir");
                Console.Write("\nSeleccione el número de ejercicio a ejecutar: ");
                
                string? input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Entrada vacía. Presione una tecla para continuar...");
                    Console.ReadKey();
                    continue;
                }
                
                if (input.Equals("x"))
                    break;

                Console.Clear();
                switch (input)
                {
                    case "0":
                        Exercise00Runner.Run();
                        Console.ReadKey();
                        break;
                    case "1":
                        Exercise01Runner.Run();
                        Console.ReadKey();
                        break;
                    case "2":
                        Exercise02Runner.Run();
                        Console.ReadKey();
                        break;
                    case "3":
                        Exercise03Runner.Run();
                        Console.ReadKey();
                        break;
                    case "4":
                        Exercise04Runner.Run();
                        Console.ReadKey();
                        break;
                    case "5":
                        Exercise05Runner.Run();
                        Console.ReadKey();
                        break;
                    case "6":
                        Exercise06Runner.Run();
                        Console.ReadKey();
                        break;
                    case "7":
                        Exercise07Runner.Run();
                        Console.ReadKey();
                        break;
                    case "8":
                        Exercise08Runner.Run();
                        Console.ReadKey();
                        break;
                    case "9":
                        Exercise09Runner.Run();
                        Console.ReadKey();
                        break;
                    case "10":
                        Exercise10Runner.Run();
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            }
            Console.WriteLine("\nPrograma finalizado. Presione una tecla para salir.");
            Console.ReadKey();
        }
    }
}