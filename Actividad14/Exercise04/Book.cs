namespace Actividad14.Exercise04
{
    public class Book(string title, string author, string category, int totalPages)
    {
        private string Title { get; } = title;
        private string Author { get; } = author;
        private string Category { get; } = category;
        public int TotalPages { get; } = totalPages;

        public void BookClassification()
        {
            if (TotalPages < 200)
            {
                Console.WriteLine("Libro corto");
            }
            else if (TotalPages < 500)
            {
                Console.WriteLine("Libro mediano");
            }
            else
            {
                Console.WriteLine("Libro extenso");
            }
        }
        
        public void PrintBookInformation()
        {
            Console.WriteLine($"Título: {Title}");
            Console.WriteLine($"Autor: {Author}");
            Console.WriteLine($"Categoría: {Category}");
            Console.WriteLine($"Número de páginas: {TotalPages}");
        }
    }
}