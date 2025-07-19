using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using MongoDemo.Entities;


namespace MongoDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IMongoCollection<User> _users;

        public TestController(IMongoDatabase database)
        {
            _users = database.GetCollection<User>("User");
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
