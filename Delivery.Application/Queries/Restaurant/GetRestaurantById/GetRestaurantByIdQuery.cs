using MediatR;

namespace Delivery.Application.Queries.Restaurant.GetRestaurantById;

public class GetRestaurantByIdQuery
{ 
    public Guid Id { get; set; }
}