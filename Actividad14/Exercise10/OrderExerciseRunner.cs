namespace Actividad14.Exercise10;

public class OrderExerciseRunner
{
    public static void Run()
    {
        var orders = new List<Order>();
        Console.Write("¿Cuántos pedidos desea registrar? ");
        int count = ReadInt();
        
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"\nPedido #{i + 1}");
            Console.Write("Cliente: ");
            string customer = Console.ReadLine()!;
            
            Console.Write("Producto: ");
            string product = Console.ReadLine()!;
            
            Console.Write("Cantidad: ");
            int quantity = ReadInt();
            
            Console.Write("Precio unitario: ");
            decimal unitPrice = ReadDecimal();
            
            orders.Add(new Order(customer, product, quantity, unitPrice));
        }

        Console.WriteLine("\nPedidos registrados");
        decimal totalGeneral = 0m;
        
        foreach (var order in orders)
        {
            order.ShowInfo();
            Console.WriteLine();
            totalGeneral += order.CalculateTotal();
        }
        Console.WriteLine($"Total general de todos los pedidos: {totalGeneral:C}");
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

    private static decimal ReadDecimal()
    {
        while (true)
        {
            if (decimal.TryParse(Console.ReadLine(), out decimal value))
                return value;
        }
    }
}