using Microsoft.AspNetCore.Mvc;

namespace ScheduleParser.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ScheduleController: ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }
}