using Delivery.Core.Enums;

namespace Delivery.Core.Entities;

public class Product : BaseEntity
{
    public Product(string title, string description, string? photoUrl, decimal price, Guid restaurantId) : base()
    {
        Title = title;
        Description = description;
        PhotoURL = photoUrl;
        Price = price;
        RestaurantId = restaurantId;
    }
    public string Title { get; private set; } 
    public string Description { get; private set; }
    public string? PhotoURL { get; private set; }
    public decimal Price { get; private set; }
    public Guid RestaurantId { get; private set; }
    
    public ProductTypeEnum ProductType { get; private set; }
    public Restaurant Restaurant { get; set; }
}