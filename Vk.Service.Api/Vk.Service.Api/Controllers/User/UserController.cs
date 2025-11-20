using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Vk.Service.Api.Controllers.User;

[Route("user")]
[ApiController]
public class UserController : BaseController
{
    private readonly ILogger<UserController> _logger;
    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
    }

    [HttpGet("user")]
    [SwaggerOperation(Description = "Возвращает текущего пользователя")]
    [SwaggerResponse(200, Description = "Текущий пользователь системы.")]
    public async Task<IActionResult> Get()
    {
        try
        {
            var result = await _
        }
    }
}
