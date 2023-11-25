using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/colors")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        [HttpGet("{color}")]
        public ActionResult<string> GetColor(Colors color)
        {
            return Ok($"Вы выбрали {color}!");
        }
    }
}
