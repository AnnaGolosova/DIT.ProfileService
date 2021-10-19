using Entities.ModelsDto;
using Mediator;
using Mediator.Commands.ProfileCommands;
using Mediator.Queries.ProfileQueries;
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
        public async Task<IActionResult> GetProfiles()
        {
            return Ok(await _mediator.Send(new GetAllProfilesQuery() { }));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdProfile(Guid id)
        {
            return Ok(await _mediator.Send(new GetByIdProfileQuery() { }));
        }
        [HttpPost]
        public async Task<IActionResult> CreateProfile([FromBody] CreateProfileDto profileDto)
        {
            return Ok(await _mediator.Send(new CreateProfileCommand() {createProfile = profileDto }));
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProfile([FromBody] UpdateProfileDto profileDto)
        {
            return Ok(await _mediator.Send(new UpdateProfileCommand() { updateProfile = profileDto }));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProfile(Guid id)
        {
            return Ok($"Profile from ID {await _mediator.Send(new DeleteProfileCommand() { Id = id })} has been deleted.");
        }
    }
}
