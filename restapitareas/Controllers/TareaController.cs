using Microsoft.AspNetCore.Mvc;
using restapitareas.Models;

namespace restapitareas.Controllers;

[ApiController]
[Route("Api/Tarea/")]
public class TareaController : ControllerBase
{
    [HttpGet("GetTareas")]
    public ActionResult<Tarea> GetTareas([])
    {
        
    }
}