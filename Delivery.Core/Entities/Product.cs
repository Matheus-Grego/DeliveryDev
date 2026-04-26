namespace Delivery.Core.Entities;

public class Product
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string PhotoURL { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal rating { get; set; }
}