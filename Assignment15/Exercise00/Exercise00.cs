namespace Assignment15
{
    public class Exercise00Runner
    {
        static void Run(string[] args)
        {
            int age;
            bool isValid = false;

            do
            {
                Console.Write("Ingrese su edad: ");
                if (int.TryParse(Console.ReadLine(), out age) && (age > 0 && age < 120))
                {
                    Console.WriteLine($"Edad válida, usted tiene {age}");
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Edad inválida.");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (!isValid);
        }
    }
}