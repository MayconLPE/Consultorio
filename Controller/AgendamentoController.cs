using Microsoft.AspNetCore.Mvc;

namespace Consultorio.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class AgendamentoController : ControllerBase
    {
       [HttpGet]
       public IActionResult Get()
        {
            return Ok("Minha primeira requisição");
        }
    }
}
