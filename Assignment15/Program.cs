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
                        Exercise00.ExerciseRunner.Run();
                        Console.ReadKey();
                        break;
                    case "1":
                        Exercise01.ExerciseRunner.Run();
                        Console.ReadKey();
                        break;
                    case "2":
                        Exercise02.ExerciseRunner.Run();
                        Console.ReadKey();
                        break;
                    case "3":
                        Exercise03.ExerciseRunner.Run();
                        Console.ReadKey();
                        break;
                    case "4":
                        Exercise04.ExerciseRunner.Run();
                        Console.ReadKey();
                        break;
                    case "5":
                        Exercise05.ExerciseRunner.Run();
                        Console.ReadKey();
                        break;
                    case "6":
                        Exercise06.ExerciseRunner.Run();
                        Console.ReadKey();
                        break;
                    case "7":
                        Exercise07.ExerciseRunner.Run();
                        Console.ReadKey();
                        break;
                    case "8":
                        Exercise08.ExerciseRunner.Run();
                        Console.ReadKey();
                        break;
                    case "9":
                        Exercise09.ExerciseRunner.Run();
                        Console.ReadKey();
                        break;
                    case "10":
                        Exercise10.ExerciseRunner.Run();
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