using Catalog.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;

namespace Catalog.Tests.IntegrationTests
{
    public class CatalogAPITests : IClassFixture<InMemoryApplicationFactory<Program>>
    {
        private readonly InMemoryApplicationFactory<Program> _factory;
        public CatalogAPITests(InMemoryApplicationFactory<Program> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task Get_Speakers()
        {
            // Arrange
            var client = _factory.CreateClient();
            var response = await client.GetAsync("/api/speaker");
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        }

        [Fact]
        public async Task post_Speaker()
        {
            var speaker = new Speaker { Id = 4, Name = "xxx", Bio = "yyy", Blog = "xxx", Company = "xxx", GitHub = "xxx", Twitter = "xxx" };
            var client = _factory.CreateClient();
          var respnse =  await client.PostAsync("api/speaker", new StringContent(JsonSerializer.Serialize(speaker), Encoding.UTF8, "application/json"));

            Assert.Equal(HttpStatusCode.OK, respnse.StatusCode);


        }
    }
}
