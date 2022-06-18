using Catalog.Data.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Tests.IntegrationTests
{
    public class InMemoryApplicationFactory<T> : WebApplicationFactory<T> where T:class
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.UseEnvironment("Testing")
                   .ConfigureTestServices(sp => {
                       var options = new DbContextOptionsBuilder<SpeakersDbContext>().UseInMemoryDatabase("Testing").Options;

                       sp.AddScoped<SpeakersDbContext>(provider => new SpeakerTestDbContext(options));
                       var serviceProvider = sp.BuildServiceProvider();
                       using var scope = serviceProvider.CreateScope();
                       var context = scope.ServiceProvider.GetRequiredService<SpeakersDbContext>();
                       context.Database.EnsureCreated();

                   });

            
            
        }
    }
}
