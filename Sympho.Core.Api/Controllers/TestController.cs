using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Sympho.Core.Domain.CommentAggregate.Entitites;
using Sympho.Core.Domain.CommentAggregate.Enums;
using Sympho.Core.Domain.SongAggregate.ValueObjects;
using Sympho.Core.Domain.UserAggregate;

namespace Sympho.Core.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase {

        [HttpPost("comment/insert")]
        public IActionResult InsertComment() {
            /*var comment = Comment.Create(
                UserId.Create("3bb5bf17-9f5f-49a5-b421-3dca87b2ef0b"),
                SongId.Create("3bb5bf17-9f5f-49a5-b421-3dca87b2ef0b"),
                "Ciao, questa canzone è bellissima",
                CommentType.TEXT,
                0,
                null);*/
            return Ok();
        }
    }
}
