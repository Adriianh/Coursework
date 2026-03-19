namespace Assignment15.Exercises
{
    public static class Exercise00Runner
    {
        public static void Run()
        {
            bool isValid = false;

            do
            {
                Console.Write("Ingrese su edad: ");
                if (int.TryParse(Console.ReadLine(), out var age) && (age > 0 && age < 120))
                {
                    Console.WriteLine($"Edad v�lida, usted tiene {age}");
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Edad inv�lida.");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (!isValid);
        }
    }
}