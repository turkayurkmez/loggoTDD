using Catalog.Business;
using Catalog.Data;
using Catalog.Entity;
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
            var speakers = speakerService.GetAll();
            return Ok(speakers);
        }


        [HttpGet("Search/{speakerName}")]
        public IActionResult Search(string speakerName)
        {
            var result = speakerService.Search(speakerName);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Speaker speaker)
        {
            speakerService.Add(speaker);
            return Ok(speaker);
        }
    }
}
