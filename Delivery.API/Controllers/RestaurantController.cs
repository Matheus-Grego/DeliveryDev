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


    public class CreateRestaurantCommand
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}