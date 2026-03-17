namespace Actividad14
{
    namespace ConsoleApp3
    {
        internal class Program
        {
            static void Main(string[] args)
            {

            }

            static void Exercise01(string[] args)
            {
                List<Student> students = new List<Student>();
                Dictionary<Student, double> averages = new Dictionary<Student, double>();

                Console.WriteLine("¿Cuántos estudiantes desea ingresar?");
                int count = int.Parse(Console.ReadLine());

                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("Ingrese el nombre del estudiante: ");
                    string name = Console.ReadLine();

                    Console.WriteLine("Ingrese la nota #1");
                    double grade1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese la nota #2");
                    double grade2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese la nota #3");
                    double grade3 = int.Parse(Console.ReadLine());

                    Student student = new Student(name, grade1, grade2, grade3);
                    students.Add(student);
                }


                Console.WriteLine("Estudiantes registrados: ");
                foreach (var student in students)
                {
                    Console.WriteLine($"Nombre: {student.name}");
                    Console.WriteLine($"   - Nota 1: {student.grade1}");
                    Console.WriteLine($"   - Nota 2: {student.grade2}");
                    Console.WriteLine($"   - Nota 3: {student.grade3}");

                    double average = student.Average(student.grade1, student.grade2, student.grade3);
                    averages.Add(student, average);
                }

                KeyValuePair<Student, double> averageMax = new KeyValuePair<Student, double>();
                foreach (var item in averages)
                {
                    if (item.Value > averageMax.Value)
                    {
                        averageMax = item;
                    }
                }
                Console.WriteLine($"El estudiante con el mejor promedio es {averageMax.Key.name} y su promedio fue de {averageMax.Value}");
            }

            static void Exercise02()
            {
                List<Product> products = new List<Product>();
                Dictionary<Product, double> prices = new Dictionary<Product, double>();

                Console.WriteLine("¿Cuántos productos desea ingresar?");
                int count = int.Parse(Console.ReadLine());

                for (int i = 0; i < count; i++)
                {
                    Console.Write("Ingrese el nombre del producto: ");
                    string name = Console.ReadLine();

                    Console.Write("Ingrese el precio del producto: ");
                    double price = double.Parse(Console.ReadLine());

                    Console.Write("Ingrese la cantidad actual del producto: ");
                    int quantity = int.Parse(Console.ReadLine());

                    Product product = new Product(name, price, quantity);
                    products.Add(product);
                }

                double totalValue = 0;
                Console.WriteLine("Productos registrados: ");
                foreach (Product product in products)
                {
                    Console.WriteLine($"Producto: {product.name}");
                    Console.WriteLine($"    - Precio: {product.price}");
                    Console.WriteLine($"    - Cantidad: {product.quantity}");

                    totalValue += product.TotalValue();
                    prices.Add(product, product.price);
                }
                Console.WriteLine($"El valor total del inventario es: Q{totalValue:F2}");

                KeyValuePair<Product, double> highestPrice = new KeyValuePair<Product, double>();
                foreach (var item in prices)
                {
                    if (item.Value > highestPrice.Value)
                    {
                        highestPrice = item;
                    }
                }
                Console.WriteLine($"El producto con el mayor costo es: {highestPrice.Key.name} y su precio es {highestPrice.Value}");
            }
        }
    }
}