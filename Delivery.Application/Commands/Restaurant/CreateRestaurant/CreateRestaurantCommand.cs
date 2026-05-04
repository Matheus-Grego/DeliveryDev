using MediatR;

namespace Delivery.Application.Commands.Restaurant.CreateRestaurant;

public class CreateRestaurantCommand 
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}