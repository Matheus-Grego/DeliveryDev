using Delivery.Application.Commands.Restaurant.CreateRestaurant;
using Microsoft.AspNetCore.Mvc;

namespace Delivery.API.Controllers;

[ApiController]
[Route("api/restaurants")]
public class RestaurantController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create(CreateRestaurantCommand weatherForecast)
    {
        return Ok();
    }
}