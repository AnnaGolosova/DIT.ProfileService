﻿using Mediator.Queries.GenderQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProfileMicroservice.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GenderController : ControllerBase
    {
        private IMediator _mediator;
        public GenderController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetProfiles()
        {
            return Ok(await _mediator.Send(new GetAllAsStringGendersQuery() { }));
        }
    }
}
