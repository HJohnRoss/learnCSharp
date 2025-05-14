using Microsoft.AspNetCore.Mvc;

namespace myapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageWallController : ControllerBase
    {
        // GET: api/MessageWall
        [HttpGet]
        public string GetMessage()
        {
            return "value";
        }

        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return $"hello id: {id}";
        }
    }
}
