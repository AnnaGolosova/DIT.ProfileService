using Mediator.Commands.FriendsCommands;
using Mediator.Queries.FriendsQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ProfileMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FriendController : ControllerBase
    {
        private IMediator _mediator;
        public FriendController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAllFrends(Guid id)
        {
            return Ok(await _mediator.Send(new GetAllFriendByProfileIdQuery() { Id = id }));
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteFrend(Guid profileId, Guid friendId )
        {
            return Ok(await _mediator.Send(new DeleteFriendCommand() { ProfileId = profileId, FriendId = friendId}));
        }
    }
}
