using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace restapi.Controller;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
    [HttpGet("testApi")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public static string testApi()
    {
        return "Running...";
    }
}