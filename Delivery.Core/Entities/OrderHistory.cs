namespace Delivery.Core.Entities;

public class OrderHistory : BaseEntity
{
    public OrderHistory(Guid orderId, DateTime orderDate, decimal totalPrice, Guid customerId, Guid deliveryPersonId, Guid restaurantId) : base()
    {
        OrderId = orderId;
        OrderDate = orderDate;
        TotalPrice = totalPrice;
        CustomerId = customerId;
        DeliveryPersonId = deliveryPersonId;
        RestaurantId = restaurantId;
    }

    public Guid OrderId { get; private set; }
    public DateTime OrderDate { get; private set; }
    public decimal TotalPrice { get; private set; }
    public Guid CustomerId { get; private set; }
    public Guid DeliveryPersonId { get; private set; }
    public Guid RestaurantId { get; private set; }
    
}