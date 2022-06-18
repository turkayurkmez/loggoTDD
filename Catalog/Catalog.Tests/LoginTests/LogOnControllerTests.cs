
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace Catalog.Tests.LoginTests
{
    public class LogOnControllerTests
    {
        [Fact]
        public void ItExists()
        {
            var controller = new Catalog.Web.API.Controllers.LogonController();
            Assert.IsAssignableFrom<ControllerBase>(controller);

        }





    }
}
