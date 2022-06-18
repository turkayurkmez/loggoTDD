using Catalog.Web.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogonController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(LoginAttempt loginAttempt)
        {
            if (loginAttempt != null && loginAttempt.Username == "validUser@test.com" && loginAttempt.Password == "validPass")
            {
                return Ok("Logon basarili");
            }

            return new ObjectResult("Username or pass invalid")
            {
                StatusCode = StatusCodes.Status401Unauthorized
            };

        }
    }
}
