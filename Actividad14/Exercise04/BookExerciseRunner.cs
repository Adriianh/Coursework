namespace Actividad14.Exercise04
{
    public static class BookExerciseRunner
    {
        public static void Run()
        {
            List<Book> books = new List<Book>();

            Console.WriteLine("¿Cuántos libros desea ingresar?");
            int count = ReadInt();

            for (int i = 0; i < count; i++)
            {
                Console.Write("Ingrese el título del libro: ");
                string title = Console.ReadLine()!;

                Console.Write("Ingrese el autor del libro: ");
                string author = Console.ReadLine()!;

                Console.Write("Ingrese la categoría del libro: ");
                string category = Console.ReadLine()!;

                Console.Write("Ingrese el número total de páginas del libro: ");
                int totalPages = ReadInt();

                Book book = new Book(title, author, category, totalPages);
                books.Add(book);
            }

            Console.Clear();
            Console.WriteLine("Los libros registrados son: ");
            foreach (var book in books)
            {
                book.PrintBookInformation();
            }

            if (books.Count > 0)
            {
                Book maxPagesBook = books[0];
                foreach (var book in books)
                {
                    if (book.TotalPages > maxPagesBook.TotalPages)
                    {
                        maxPagesBook = book;
                    }
                }
                Console.WriteLine("\nEl libro con más páginas es:");
                maxPagesBook.PrintBookInformation();
            }
            else
            {
                Console.WriteLine("No hay libros registrados para comparar.");
            }
        }
        
        private static int ReadInt()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int value))
                    return value;
                Console.WriteLine("Valor inválido, intente de nuevo:");
            }
        }
    }
}