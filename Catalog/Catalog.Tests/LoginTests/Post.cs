using Catalog.Web.API.Controllers;
using Catalog.Web.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace Catalog.Tests.LoginTests
{
    public class Post
    {
        [Fact]
        public void ItExist()
        {
            LogonController controller = new LogonController();
            var response = controller.Post(null);
            Assert.IsAssignableFrom<IActionResult>(response);

        }
        [Fact]
        public void ItReturnsUnauthorizedWhenInvalidUser()
        {
            LogonController controller = new LogonController();
            var loginAttempt = new LoginAttempt { Username = "invalid@test.com", Password = "invalidPass" };
            var response = (ObjectResult)controller.Post(loginAttempt);

            Assert.NotNull(response.StatusCode);
            Assert.Equal(StatusCodes.Status401Unauthorized, response.StatusCode);
            //Assert.IsAssignableFrom<UnauthorizedResult>(response);
        }
        [Fact]
        public void ItReturnsOkWhenValidUser()
        {
            LogonController controller = new LogonController();
            var loginAttempt = new LoginAttempt
            {
                Username = "validUser@test.com",
                Password = "validPass"
            };

            var response = (ObjectResult)controller.Post(loginAttempt);

            Assert.NotNull(response.StatusCode);
            Assert.Equal(StatusCodes.Status200OK, response.StatusCode);

        }
    }
}
