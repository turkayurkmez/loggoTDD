using Catalog.Web.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpeakerController : ControllerBase
    {
        public IActionResult Search(string speakerName)
        {
            var speakers = new List<Speaker>
            {
                new Speaker
                {
                     Id = 1,
                     Name = "Türkay Ürkmez",
                     Blog = "http://www.turkayurkmez.com",


                },

                   new Speaker
                {
                     Id = 2,
                     Name = "Türkan Ürkmez",
                     Blog = "http://www.turkayurkmez.com",


                }

            };

            var result = speakers.Where(s => s.Name.ToLower().Contains(speakerName.ToLower())).ToList();

            return Ok(result);
        }
    }
}
