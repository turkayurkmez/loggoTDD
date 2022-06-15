using Catalog.Business;
using Catalog.Data;
using Catalog.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpeakerController : ControllerBase
    {
        private readonly IRepository<Speaker> speakerRepository;
        private readonly ILogger logger;
        private readonly ISpeakerService speakerService;

        public SpeakerController(ISpeakerService speakerService)
        {
            this.speakerService = speakerService;
            //this.logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var speakers = speakerRepository.GetAll();
            return Ok(speakers);
        }


        [HttpGet]
        public IActionResult Search(string speakerName)
        {
            //var speakers = new List<Speaker>
            //{
            //    new Speaker
            //    {
            //         Id = 1,
            //         Name = "Mustafa",
            //         Blog = "http://www.turkayurkmez.com",


            //    },

            //       new Speaker
            //    {
            //         Id = 2,
            //         Name = "Murtaza",
            //         Blog = "http://www.turkayurkmez.com",


            //    },
            //       new Speaker
            //    {
            //         Id = 3,
            //         Name = "Mahmut",
            //         Blog = "http://www.turkayurkmez.com",


            //    },
            //       new Speaker
            //    {
            //         Id =4,
            //         Name = "Türkay",
            //         Blog = "http://www.turkayurkmez.com",


            //    }


            // };

            //var result = speaker.Where(s => s.Name.ToLower().Contains(speakerName.ToLower())).ToList();
            var result = speakerService.Search(speakerName);
           // speakerService.Search(speakerName);
            return Ok(result);
        }
    }
}
