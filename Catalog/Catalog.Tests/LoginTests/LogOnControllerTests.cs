
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
