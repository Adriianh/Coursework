namespace Actividad14.Exercise10;

public class Order(string customer, string product, int quantity, decimal unitPrice)
{
    private string Customer { get; } = customer;
    private string Product { get; } = product;
    private int Quantity { get; } = quantity;
    private decimal UnitPrice { get; } = unitPrice;

    private decimal CalculateSubtotal()
    {
        return Quantity * UnitPrice;
    }

    private decimal CalculateShippingCost()
    {
        var subtotal = CalculateSubtotal();

        switch (subtotal)
        {
            case >= 1000:
                return 0m;
            case >= 500:
                return 20m;
            default:
                return 50m;
        }
    }

    public decimal CalculateTotal()
    {
        return CalculateShippingCost() + CalculateSubtotal();
    }

    public void ShowInfo()
    {
        Console.WriteLine($"  - Cliente: {Customer}");
        Console.WriteLine($"  - Producto: {Product}");
        Console.WriteLine($"  - Cantidad: {Quantity}");
        Console.WriteLine($"  - Precio unitario: {UnitPrice:C}");
        Console.WriteLine($"  - Subtotal: {CalculateSubtotal():C}");
        Console.WriteLine($"  - Costo de envío: {CalculateShippingCost():C}");
        Console.WriteLine($"  - Total: {CalculateTotal():C}");
    }
}