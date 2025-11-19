using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Vk.Service.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExampleController : ControllerBase
    {
        [HttpGet("message")]
        public async Task<IActionResult> GetMessagesAsync()
        {
            return Ok(new { message = "Hello from my App"});
        }
    }
}
