using Delivery.Core.Enums;

namespace Delivery.Core.Entities;

public class Order : BaseEntity
{
    public List<OrderItem> Items { get; set; }
    public Decimal TotalPrice { get; private set; }
    public OrderStatusEnum Status { get; private set; }
    public Guid RestaurantId { get; private set; }
    public Guid? DeliveryPersonId { get; private set; }
    
    public void SetDeliveryPersonId(Guid deliveryPersonId)
    {
        DeliveryPersonId = deliveryPersonId;
    }
    
    public void Accept()
    {
        if(Status != OrderStatusEnum.Requested)
            throw new InvalidOperationException("Order needs to be requested");
        
        Status = OrderStatusEnum.Accepted;
    }

    public void SetReadyForPickup()
    {
        if(Status != OrderStatusEnum.InPreparation)
            throw new InvalidOperationException("Order needs to be in preparation");
        Status = OrderStatusEnum.ReadyForPickup;
    }
    

    public void Reject()
    {
        Status = OrderStatusEnum.Rejected;
    }
}