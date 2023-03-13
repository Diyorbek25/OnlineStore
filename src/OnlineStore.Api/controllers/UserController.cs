using Microsoft.AspNetCore.Mvc;

namespace OnlineStore.Api.Controllers;

[ApiController]
[Route("api/User")]
public class UserController : ControllerBase
{
    [HttpGet]
    public ActionResult Get(int a)
    {
        return Ok();
    }
}
