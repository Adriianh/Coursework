namespace Actividad14.Exercise07
{
    public class Product(string code, string name, decimal price, int stock)
    {
        private string Code { get; } = code;
        private string Name { get; } = name;
        private decimal Price { get; } = price;
        private int Stock { get; } = stock;

        private string GetStockStatus()
        {
            if (Stock == 0)
                return "Agotado";
            if (Stock <= 5)
                return "Bajo";
            return "Normal";
        }

        public void ShowInfo()
        {
            Console.WriteLine($"  - Código: {Code}");
            Console.WriteLine($"  - Nombre: {Name}");
            Console.WriteLine($"  - Precio: {Price:C}");
            Console.WriteLine($"  - Stock: {Stock} ({GetStockStatus()})");
        }
    }
}