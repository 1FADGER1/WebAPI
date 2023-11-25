using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace WebApplication1.Controllers
{
    [Route("api/usersvk")]
    [ApiController]
    public class VKController : ControllerBase
    {
        static readonly HttpClient client = new HttpClient();
        [HttpGet("{iduser}")]
        public async Task<ActionResult<string>> GetInformationUser(string iduser)
        {
            HttpResponseMessage response = await client.GetAsync($"https://api.vk.com/method/users.get?user_ids={iduser}" +
                $"&fields=bdate,city,games,last_seen,music,photo_400_orig" +
                $"&access_token=052735c2052735c2052735c26706315b2200527052735c260450694efe709d5b6cf0840&v=5.131");
            return Ok(await response.Content.ReadAsStringAsync());
        }
    }
}
