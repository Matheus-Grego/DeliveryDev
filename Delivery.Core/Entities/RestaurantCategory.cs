namespace Delivery.Core.Entities;

public class RestaurantCategory : BaseEntity
{
    public RestaurantCategory(Guid categoryId, Guid restaurantId)
    {
        CategoryId = categoryId;
        RestaurantId = restaurantId;
    }
    public Guid CategoryId { get; set; }
    public Guid RestaurantId { get; set; }
}