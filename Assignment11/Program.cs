using System;

namespace Assignment11
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==============================");
                Console.WriteLine("      MENÚ DE EJERCICIOS");
                Console.WriteLine("==============================");
                for (int i = 1; i <= 25; i++)
                {
                    Console.WriteLine($"{i}. Ejercicio #{i}");
                }
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione el número de ejercicio a ejecutar: ");
                int opcion;
                try { opcion = int.Parse(Console.ReadLine()); } catch { opcion = -1; }
                
                if (opcion == 0) break;
                if (opcion < 1 || opcion > 25)
                {
                    Console.WriteLine("Opción inválida. Presione una tecla para continuar...");
                    Console.ReadKey();
                    continue;
                }
                Console.Clear();
                
                switch (opcion)
                {
                    case 1: EjecutarEjercicio1(); break;
                    case 2: EjecutarEjercicio2(); break;
                    case 3: EjecutarEjercicio3(); break;
                    case 4: EjecutarEjercicio4(); break;
                    case 5: EjecutarEjercicio5(); break;
                    case 6: EjecutarEjercicio6(); break;
                    case 7: EjecutarEjercicio7(); break;
                    case 8: EjecutarEjercicio8(); break;
                    case 9: EjecutarEjercicio9(); break;
                    case 10: EjecutarEjercicio10(); break;
                    case 11: EjecutarEjercicio11(); break;
                    case 12: EjecutarEjercicio12(); break;
                    case 13: EjecutarEjercicio13(); break;
                    case 14: EjecutarEjercicio14(); break;
                    case 15: EjecutarEjercicio15(); break;
                    case 16: EjecutarEjercicio16(); break;
                    case 17: EjecutarEjercicio17(); break;
                    case 18: EjecutarEjercicio18(); break;
                    case 19: EjecutarEjercicio19(); break;
                    case 20: EjecutarEjercicio20(); break;
                    case 21: EjecutarEjercicio21(); break;
                    case 22: EjecutarEjercicio22(); break;
                    case 23: EjecutarEjercicio23(); break;
                    case 24: EjecutarEjercicio24(); break;
                    case 25: EjecutarEjercicio25(); break;
                }
                EsperarUsuario();
            }
        }

        static void EjecutarEjercicio1()
        {
            Console.WriteLine("Ejercicio #1: Mostrar un saludo en pantalla");
            Saludar();
        }
        static void EjecutarEjercicio2()
        {
            Console.WriteLine("Ejercicio #2: Mostrar un nombre en pantalla");
            MostrarNombre();
        }
        static void EjecutarEjercicio3()
        {
            Console.WriteLine("Ejercicio #3: Mostrar un mensaje en pantalla");
            MostrarMensaje();
        }
        static void EjecutarEjercicio4()
        {
            Console.WriteLine("Ejercicio #4: Imprimir una línea separadora");
            Linea();
        }
        static void EjecutarEjercicio5()
        {
            Console.WriteLine("Ejercicio #5: Mostrar un menú simple");
            MostrarMenu();
        }
        static void EjecutarEjercicio6()
        {
            Console.WriteLine("Ejercicio #6: Saludar a una persona");
            Console.Write("Ingrese el nombre: ");
            
            string name = Console.ReadLine();
            Saludar(name);
        }
        static void EjecutarEjercicio7()
        {
            Console.WriteLine("Ejercicio #7: Mostrar el doble de un número");
            Console.Write("Ingrese un número: ");
            
            int number = int.Parse(Console.ReadLine());
            MostrarDoble(number);
        }
        static void EjecutarEjercicio8()
        {
            Console.WriteLine("Ejercicio #8: Mostrar el cuadrado de un número");
            Console.Write("Ingrese un número: ");
            
            int number = int.Parse(Console.ReadLine());
            MostrarCuadrado(number);
        }
        static void EjecutarEjercicio9()
        {
            Console.WriteLine("Ejercicio #9: Sumar dos números y mostrar el resultado");
            
            Console.Write("Ingrese el primer número: ");
            int a = int.Parse(Console.ReadLine());
            
            Console.Write("Ingrese el segundo número: ");
            int b = int.Parse(Console.ReadLine());
            
            SumarMostrar(a, b);
        }
        static void EjecutarEjercicio10()
        {
            Console.WriteLine("Ejercicio #10: Imprimir un texto varias veces");
            
            Console.Write("Ingrese el texto: ");
            string text = Console.ReadLine();
            
            Console.Write("¿Cuántas veces?: ");
            int times = int.Parse(Console.ReadLine());
            
            ImprimirRepetido(text, times);
        }
        static void EjecutarEjercicio11()
        {
            Console.WriteLine("Ejercicio #11: Sumar dos números y retornar el resultado");
            
            Console.Write("Ingrese el primer número: ");
            int a = int.Parse(Console.ReadLine());
            
            Console.Write("Ingrese el segundo número: ");
            int b = int.Parse(Console.ReadLine());
            
            int result = Sumar(a, b);
            Console.WriteLine($"Resultado: {result}");
        }
        static void EjecutarEjercicio12()
        {
            Console.WriteLine("Ejercicio #12: Restar dos números y retornar el resultado");
            
            Console.Write("Ingrese el primer número: ");
            int a = int.Parse(Console.ReadLine());
            
            Console.Write("Ingrese el segundo número: ");
            int b = int.Parse(Console.ReadLine());
            
            int result = Restar(a, b);
            Console.WriteLine($"Resultado: {result}");
        }
        static void EjecutarEjercicio13()
        {
            Console.WriteLine("Ejercicio #13: Multiplicar dos números y retornar el resultado");
            
            Console.Write("Ingrese el primer número: ");
            int a = int.Parse(Console.ReadLine());
            
            Console.Write("Ingrese el segundo número: ");
            int b = int.Parse(Console.ReadLine());
            
            int result = Multiplicar(a, b);
            Console.WriteLine($"Resultado: {result}");
        }
        static void EjecutarEjercicio14()
        {
            Console.WriteLine("Ejercicio #14: Dividir dos números y retornar el resultado");
            
            Console.Write("Ingrese el primer número: ");
            double a = double.Parse(Console.ReadLine());
            
            Console.Write("Ingrese el segundo número: ");
            double b = double.Parse(Console.ReadLine());
            
            double result = Dividir(a, b);
            Console.WriteLine($"Resultado: {result}");
        }
        static void EjecutarEjercicio15()
        {
            Console.WriteLine("Ejercicio #15: Determinar si un número es par");
            
            Console.Write("Ingrese un número: ");
            int number = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"¿Es par? {EsPar(number)}");
        }
        static void EjecutarEjercicio16()
        {
            Console.WriteLine("Ejercicio #16: Determinar si un número es positivo");
            
            Console.Write("Ingrese un número: ");
            int number = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"¿Es positivo? {EsPositivo(number)}");
        }
        static void EjecutarEjercicio17()
        {
            Console.WriteLine("Ejercicio #17: Determinar el mayor de dos números");
            
            Console.Write("Ingrese el primer número: ");
            int a = int.Parse(Console.ReadLine());
            
            Console.Write("Ingrese el segundo número: ");
            int b = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Mayor: {Mayor(a, b)}");
        }
        static void EjecutarEjercicio18()
        {
            Console.WriteLine("Ejercicio #18: Determinar el menor de tres números");
            
            Console.Write("Ingrese el primer número: ");
            int a = int.Parse(Console.ReadLine());
            
            Console.Write("Ingrese el segundo número: ");
            int b = int.Parse(Console.ReadLine());
            
            Console.Write("Ingrese el tercer número: ");
            int c = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Menor: {MenorDeTres(a, b, c)}");
        }
        static void EjecutarEjercicio19()
        {
            Console.WriteLine("Ejercicio #19: Determinar si un número es múltiplo de otro");
            
            Console.Write("Ingrese el primer número: ");
            int n = int.Parse(Console.ReadLine());
            
            Console.Write("Ingrese el segundo número: ");
            int m = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"¿Es múltiplo? {EsMultiplo(n, m)}");
        }
        static void EjecutarEjercicio20()
        {
            Console.WriteLine("Ejercicio #20: Contar la cantidad de caracteres de un texto");
            
            Console.Write("Ingrese el texto: ");
            string text = Console.ReadLine();
            
            Console.WriteLine($"Cantidad de letras: {ContarLetras(text)}");
        }
        static void EjecutarEjercicio21()
        {
            Console.WriteLine("Ejercicio #21: Contar la cantidad de vocales en un texto");
            
            Console.Write("Ingrese el texto: ");
            string text = Console.ReadLine();
            
            Console.WriteLine($"Cantidad de vocales: {ContarVocales(text)}");
        }
        static void EjecutarEjercicio22()
        {
            Console.WriteLine("Ejercicio #22: Repetir un texto varias veces y retornar el resultado");
            
            Console.Write("Ingrese el texto: ");
            string text = Console.ReadLine();
            
            Console.Write("¿Cuántas veces?: ");
            int times = int.Parse(Console.ReadLine());
            
            Repetir(text, times);
        }
        static void EjecutarEjercicio23()
        {
            Console.WriteLine("Ejercicio #23: Calcular la suma de los números del 1 hasta N");
            
            Console.Write("Ingrese el valor de N: ");
            int n = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Suma del 1 al {n}: {SumarDel1AlN(n)}");
        }
        static void EjecutarEjercicio24()
        {
            Console.WriteLine("Ejercicio #24: Calcular el factorial de un número");
            
            Console.Write("Ingrese el número: ");
            int n = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Factorial de {n}: {Factorial(n)}");
        }
        static void EjecutarEjercicio25()
        {
            Console.WriteLine("Ejercicio #25: Determinar si un número es primo");
            
            Console.Write("Ingrese el número: ");
            int n = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"¿Es primo? {EsPrimo(n)}");
        }

        static void EsperarUsuario()
        {
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        static void Saludar()
        {
            Console.WriteLine("Hola, bienvenido");
        }

        static void MostrarNombre()
        {
            string name = "Adrian";
            Console.WriteLine(name);
        }

        static void MostrarMensaje()
        {
            Console.WriteLine("Programación en C#");
        }

        static void Linea()
        {
            Console.WriteLine("----------------");
        }

        static void MostrarMenu()
        {
            Console.WriteLine("1. Opción uno");
            Console.WriteLine("2. Opción dos");
            Console.WriteLine("3. Opción tres");
        }

        static void Saludar(string name)
        {
            Console.WriteLine($"Hola {name}");
        }

        static void MostrarDoble(int number)
        {
            Console.WriteLine(number * 2);
        }

        static void MostrarCuadrado(int number)
        {
            Console.WriteLine(number * number);
        }

        static void SumarMostrar(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
        }

        static void ImprimirRepetido(string text, int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine(text);
            }
        }

        static int Sumar(int a, int b)
        {
            return a + b;
        }

        static int Restar(int a, int b)
        {
            return a - b;
        }

        static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        static double Dividir(double a, double b)
        {
            if (b == 0) return double.NaN;
            return a / b;
        }

        static bool EsPar(int number)
        {
            return number % 2 == 0;
        }

        static bool EsPositivo(int number)
        {
            return number > 0;
        }

        static int Mayor(int a, int b)
        {
            return a > b ? a : b;
        }

        static int MenorDeTres(int a, int b, int c)
        {
            int min = a;
            if (b < min) min = b;
            if (c < min) min = c;
            return min;
        }

        static bool EsMultiplo(int n, int m)
        {
            if (m == 0) return false;
            return n % m == 0;
        }

        static int ContarLetras(string text)
        {
            return text.Length;
        }

        static int ContarVocales(string text)
        {
            int count = 0;
            string vowels = "aeiouAEIOU";
            
            foreach (char c in text)
            {
                if (vowels.Contains(c)) count++;
            }
            
            return count;
        }

        static void Repetir(string text, int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine(text);
            }
        }

        static int SumarDel1AlN(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }

        static int Factorial(int n)
        {
            if (n < 0) return -1;
            int result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        static bool EsPrimo(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}