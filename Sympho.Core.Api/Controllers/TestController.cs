using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Sympho.Core.Domain.Entities;

namespace Sympho.Core.Api.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase {

        [HttpPost("insert")]
        public IActionResult Insert() {
            var client = new MongoClient("mongodb+srv://sympho:o6YwVYf8lLYbhPME@maincluster.ox2jobq.mongodb.net/?retryWrites=true&w=majority");
            var database = client.GetDatabase("symphodb");
            var collection = database.GetCollection<Filter>("filters");

            var filter = new Filter() {
                Name = "filter1",
                Genres = new List<string> {
                    "Synth Pop",
                    "New Wave"
                },
                ImgUrl = "www.site.domain/uasfdsfsds.jpg",
                CreatedDateTime= DateTime.Now,
                UpdatedDateTime= DateTime.Now,
            };

            collection.InsertOne(filter);
            return Ok("Filtro inserito");
        }
    }
}
