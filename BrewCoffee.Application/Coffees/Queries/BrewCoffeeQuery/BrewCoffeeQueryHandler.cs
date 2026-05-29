using BrewCoffee.Application.Coffees.DataTransferObjects;
using BrewCoffee.Core.Aggregates.CoffeeAggregate;
using MediatR;

namespace BrewCoffee.Application.Coffees.Queries.BrewCoffeeQuery
{
    public record BrewCoffeeQuery : IRequest<BrewCoffeeQueryResponse>
    { }

    public class BrewCoffeeQueryHandler : IRequestHandler<BrewCoffeeQuery, BrewCoffeeQueryResponse>
    {
        public Task<BrewCoffeeQueryResponse> Handle(BrewCoffeeQuery request, CancellationToken cancellationToken)
        {
            var coffee = new Coffee();
            var brewedCoffee = coffee.Brew(DateTime.UtcNow);

            return Task.FromResult(new BrewCoffeeQueryResponse(brewedCoffee.Message, brewedCoffee.Prepared));
        }
    }
}
