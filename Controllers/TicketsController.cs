using Microsoft.AspNetCore.Mvc;

namespace PlatformDemo2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketsController :ControllerBase
    {
        [HttpGet]
        // [Route("api/tickets")]
        public IActionResult Get ()
        {
        return Ok("Reading all tickets");
        }

        [HttpGet("{id}")]
        // [Route("api/tickets/{id}")]
        public IActionResult Get (int id)
        {
        return Ok($"Reading ticket: #{id}.");
        }

        [HttpPost]
        // [Route("api/tickets")]
        public IActionResult Post ()
        {
        return Ok("Creating a ticket");
        }

        [HttpPut]
        // [Route("api/tickets")]
        public IActionResult Put ()
        {
        return Ok("Updating a tickets");
        }

        [HttpDelete("{id}")]
        // [Route("api/tickets/{id}")]
        public IActionResult Delete (int id)
        {
        return Ok($"Delete ticket: {id}");
        }
    }
}