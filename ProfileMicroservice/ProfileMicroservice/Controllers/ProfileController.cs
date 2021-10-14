using Context;
using Entities.Models;
using Mediator;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System.Threading;
using System.Threading.Tasks;

namespace ProfileMicroservice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfileController : ControllerBase
    {
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

        public ProfileController()
        {
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //return Ok(_context.Set<Profile>());//
            return Ok(await Mediator.Send(new GetAllQuery<Profile>() { }));
        }
    }
}
