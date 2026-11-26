using Microsoft.AspNetCore.Mvc;

namespace NameApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NameController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetName()
        {
            return Ok(new { name = "Sai Ram Surapaneni" });
        }
    }
}