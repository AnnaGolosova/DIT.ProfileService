using Entities.Models;
using Mediator;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Mediator;
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
            //return Ok(_context.Set<Profile>());//
            return Ok(await _mediator.Send(new GetAllProfilesQuery() { }));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _mediator.Send(new GetAllProfilesQuery() { }));
        }
    }
}
