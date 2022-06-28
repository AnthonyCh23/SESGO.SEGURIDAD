using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Seguridad.Service.EventHandlers.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seguridad.SESGO.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
    
        private readonly ILogger<DefaultController> _logger;
        private readonly IMediator _mediator;

        public UsuarioController(ILogger<DefaultController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate(UsuarioLoginCommand command)
        {
            if (ModelState.IsValid)
            {
                var result = await _mediator.Send(command);
                /*if (!result.Succeeded)
                {
                    return BadRequest();
                }*/
                return Ok(result);
            }

            return BadRequest();
        }
    }
}
