using Microsoft.AspNetCore.Mvc;

namespace PlatformDemo2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Reading all tickets");
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok($"Reading Project: #{id}.");
        }

        //api/projects/{pid}/tickets?tid={tid}
        [HttpGet]
        [Route("/api/projects/{pid}/tickets")]
        public IActionResult GetById(int pId,[FromQuery] int tId)
        {
            if (tId == 0)
            {
                return Ok($"Reading all the tickets belong to Project #{pId}");
            }
            return Ok($"Reading Project: #{pId} , Ticket: #{tId} .");
        }
        [HttpPost]
        public IActionResult Post()
        {
            return Ok("Creating a project");
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id)
        {
            return Ok($"Updating project: #{id}");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok($"Deleting project : #{id}");
        }
    }
}