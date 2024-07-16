namespace Eco.Products.Models;

public class Product
{
    public required string Name { get; set; }
    public required Decimal Price { get; set; }
    public required Decimal HistoryPrice { get; set; }
    public double DiscountPercengate { get; set; } = 0.0;
}