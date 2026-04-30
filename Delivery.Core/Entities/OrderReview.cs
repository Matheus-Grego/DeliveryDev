using Delivery.Core.Enums;

namespace Delivery.Core.Entities;

public class OrderReview : BaseEntity
{
    public OrderReview(Guid costumerId, Guid orderId, string? title, string description, int rating) : base()
    {
        CostumerId = costumerId;
        OrderId = orderId;
        Title = title;
        Description = description;
        Rating = rating;
        Status = OrderReviewEnum.Send;
    }

    public Guid CostumerId { get; private set; }
    public Guid OrderId { get; private set; }
    public string? Title { get; private set; }
    public string Description { get; private set; }
    public int Rating { get; private set; }
    public OrderReviewEnum Status { get; private set; }
   
}