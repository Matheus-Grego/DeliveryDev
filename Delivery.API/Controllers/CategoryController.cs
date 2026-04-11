using Microsoft.AspNetCore.Mvc;

namespace Delivery.API.Controllers;

[ApiController]
[Route("api/category")]
public class CategoryController : ControllerBase
{
    public async Task<IActionResult> Create()
    {
        return Ok();
    }
}