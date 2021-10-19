using Mediator.Queries.FriendsQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ProfileMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FrendsController : ControllerBase
    {
        private IMediator _mediator;
        public FrendsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAllFrends(Guid id)
        {
            return Ok(await _mediator.Send(new GetAllFriendByProfileIdQuery() { Id = id }));
        }
    }
}
