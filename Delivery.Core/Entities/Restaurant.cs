namespace Delivery.Core.Entities;

public class Restaurant : BaseEntity
{
    public Restaurant(string name, string address, string phone, decimal minimalPrice, List<RestaurantCategory> categories) : base()
    {
        Name = name;
        Address = address;
        PhoneNumber = phone;
        MinimalPrice = minimalPrice;
        Categories = categories;
    }
    public string Name { get; private set; } 
    public string Address { get; private set; } 
    public string PhoneNumber { get; private set; }
    public decimal MinimalPrice { get; private set; }
    public List<RestaurantCategory> Categories { get; private set; } 
}