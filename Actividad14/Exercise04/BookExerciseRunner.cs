namespace Actividad14.Exercise04
{
    public static class BookExerciseRunner
    {
        public static void Run()
        {
            List<Book> books = new List<Book>();

            Console.WriteLine("¿Cuántos libros desea ingresar?");
            int count = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < count; i++)
            {
                Console.Write("Ingrese el título del libro: ");
                string title = Console.ReadLine()!;

                Console.WriteLine("Ingrese el autor del libro: ");
                string author = Console.ReadLine()!;

                Console.WriteLine("Ingrese la categoría del libro: ");
                string category = Console.ReadLine()!;

                Console.WriteLine("Ingrese el número total de páginas del libro: ");
                int totalPages = int.Parse(Console.ReadLine()!);

                Book book = new Book(title, author, category, totalPages);
                books.Add(book);
            }

            Console.WriteLine("Los libros registrados son: ");
            foreach (var book in books)
            {
                book.PrintBookInformation();
                Console.Write("    - Clasificación del libro: ");
                book.BookClassification();
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
    }
}