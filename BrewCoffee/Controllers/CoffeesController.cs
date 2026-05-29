using BrewCoffee.Application.Coffees.Queries.BrewCoffeeQuery;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BrewCoffee.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoffeesController(ILogger<CoffeesController> logger, IMediator mediator) : ControllerBase
    {
        private readonly ILogger<CoffeesController> _logger = logger;
        private readonly IMediator _mediator = mediator;

        [HttpGet("brew-coffee")]
        public async Task<IActionResult> BrewCoffee() => Ok(await _mediator.Send(new BrewCoffeeQuery()));
    }
}
