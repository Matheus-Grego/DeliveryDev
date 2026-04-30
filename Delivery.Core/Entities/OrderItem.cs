namespace Delivery.Core.Entities;

public class OrderItem : BaseEntity
{
    public OrderItem(Guid productId, int quantity, string observation, decimal unitPrice)
    {
        ProductId = productId;
        Quantity = quantity;
        Observation = observation;
        UnitPrice = unitPrice;
        TotalPrice = unitPrice * quantity;
    }

    public Guid ProductId { get; private set; }
    public int Quantity { get; private set; }
    public string Observation { get; private set; }
    public decimal UnitPrice { get; private set; }
    public Decimal TotalPrice { get; private set; }
}