using Microsoft.AspNetCore.Mvc;

namespace NetCore.Boilerplate.API.Controllers;

[ApiController]
[Route("api/[controller]")] // ASP.NET Core substitutes [controller] with the controller’s class name minus the Controller suffix.
public class PingController : ControllerBase
{
    // GET: api/ping
    [HttpGet] 
    public IActionResult Get() => Ok(new { pong = true, serverTime = DateTimeOffset.UtcNow });

    // GET: api/ping/status
    [HttpGet("status")] 
    public IActionResult GetStatus()
    {
        return Ok(new { status = "alive", time = DateTimeOffset.UtcNow });
    }

    // GET: api/ping/version
    [HttpGet("version")] 
    public IActionResult GetVersion()
    {
        return Ok(new { apiVersion = "1.0.0" });
    }

    // GET: api/bad
    [HttpGet("bad")]
    public IActionResult GetBad()
    {
        return BadRequest(new { error = "Something was wrong with your request" });
    }
}
