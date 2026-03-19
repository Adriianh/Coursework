using StudentListRunner = Actividad14.Exercise01.StudentExerciseRunner;
using ProductListRunner = Actividad14.Exercise02.ProductExerciseRunner;
using EmployeeExerciseRunner = Actividad14.Exercise03.EmployeeExerciseRunner;
using BookExerciseRunner = Actividad14.Exercise04.BookExerciseRunner;
using SaleExerciseRunner = Actividad14.Exercise05.SaleExerciseRunner;
using StudentDictRunner = Actividad14.Exercise06.StudentExerciseRunner;
using ProductDictRunner = Actividad14.Exercise07.ProductExerciseRunner;
using AccountExerciseRunner = Actividad14.Exercise08.AccountExerciseRunner;
using CourseExerciseRunner = Actividad14.Exercise09.CourseExerciseRunner;
using OrderExerciseRunner = Actividad14.Exercise10.OrderExerciseRunner;

namespace Actividad14;

internal static class Program
{
    private static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("\nSeleccione el ejercicio a ejecutar:");
            Console.WriteLine("1. Sistema de registro de estudiantes");
            Console.WriteLine("2. Sistema de inventario de productos");
            Console.WriteLine("3. Sistema de empleados de una empresa");
            Console.WriteLine("4. Sistema de biblioteca");
            Console.WriteLine("5. Sistema de ventas de una tienda");
            Console.WriteLine("6. Registro de estudiantes utilizando diccionario");
            Console.WriteLine("7. Sistema de productos por código");
            Console.WriteLine("8. Sistema de cuentas bancarias");
            Console.WriteLine("9. Sistema de cursos universitarios");
            Console.WriteLine("10. Sistema de pedidos de clientes");
            Console.WriteLine("0. Salir");
            Console.Write("Opción: ");
            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    StudentListRunner.Run();
                    PauseAndClear();
                    break;
                case "2":
                    ProductListRunner.Run();
                    PauseAndClear();
                    break;
                case "3":
                    EmployeeExerciseRunner.Run();
                    PauseAndClear();
                    break;
                case "4":
                    BookExerciseRunner.Run();
                    PauseAndClear();
                    break;
                case "5":
                    SaleExerciseRunner.Run();
                    PauseAndClear();
                    break;
                case "6":
                    StudentDictRunner.Run();
                    PauseAndClear();
                    break;
                case "7":
                    ProductDictRunner.Run();
                    PauseAndClear();
                    break;
                case "8":
                    AccountExerciseRunner.Run();
                    PauseAndClear();
                    break;
                case "9":
                    CourseExerciseRunner.Run();
                    PauseAndClear();
                    break;
                case "10":
                    OrderExerciseRunner.Run();
                    PauseAndClear();
                    break;
                case "0":
                    Console.WriteLine("Saliendo...");
                    return;
                default:
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                    PauseAndClear();
                    break;
            }
        }
    }

    private static void PauseAndClear()
    {
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey(true);
        Console.Clear();
    }
}