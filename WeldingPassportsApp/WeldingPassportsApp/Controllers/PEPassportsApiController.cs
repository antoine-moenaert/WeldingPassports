﻿using Application.Requests.PEPassports;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeldingPassportsApp.Controllers
{
    [AllowAnonymous]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class PEPassportsApiController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PEPassportsApiController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(nameof(GetMaxAVNumber))]
         public async Task<ActionResult<string>> GetMaxAVNumber(int trainingCenterID)
        {
            var query = new GetPEPassportGetMaxAVNumberApiRequest(trainingCenterID, this);
            return await _mediator.Send(query);
        }
    }
}
