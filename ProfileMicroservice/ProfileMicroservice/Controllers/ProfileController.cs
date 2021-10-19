using Entities.ModelsDto;
using Mediator;
using Mediator.Commands.ProfileCommands;
using Mediator.Queries.ProfileQuery;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ProfileMicroservice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfileController : ControllerBase
    {
        private IMediator _mediator;

        public ProfileController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _mediator.Send(new GetAllProfilesQuery() { }));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _mediator.Send(new GetAllProfilesQuery() { }));
        }
        [HttpPost]
        public async Task<IActionResult> CreateProfile([FromBody] CreateProfileDto profileDto)
        {
            return Ok(await _mediator.Send(new CreateProfileCommand() {createProfile = profileDto }));
        }
    }
}
