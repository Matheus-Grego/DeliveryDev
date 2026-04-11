using Delivery.Core.Entities;

namespace Delivery.Infrastructure.Persistance;

public class DeliveryDbContext
{
    public DeliveryDbContext()
    {
        
    }
    
    public List<RestaurantCategory> RestaurantCategories { get; set; }
    public List<Order> Orders { get; set; }
    public List<Restaurant> Restaurants { get; set; }
    public List<DeliveryPerson> DeliveryPersons { get; set; }
    public List<Costumer> Costumers { get; set; }
}