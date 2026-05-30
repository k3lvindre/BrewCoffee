using BrewCoffee.Application.Coffees.DataTransferObjects;
using BrewCoffee.Core.Aggregates.CoffeeAggregate;
using BrewCoffee.Core.Services.Weather;
using MediatR;

namespace BrewCoffee.Application.Coffees.Queries.BrewCoffeeQuery
{
    public record BrewCoffeeQuery : IRequest<BrewCoffeeQueryResponseDto>
    { }

    public class BrewCoffeeQueryHandler(IWeatherService weatherService) : IRequestHandler<BrewCoffeeQuery, BrewCoffeeQueryResponseDto>
    {
        private readonly IWeatherService weatherService = weatherService;

        public async Task<BrewCoffeeQueryResponseDto> Handle(BrewCoffeeQuery request, CancellationToken cancellationToken)
        {
            var coffee = new Coffee();
            var currentWeatherTemparature = await weatherService.GetCurrentWeatherTemparatureAsync();
            var brewedCoffee = coffee.Brew(DateTime.UtcNow, currentWeatherTemparature);

            return await Task.FromResult(new BrewCoffeeQueryResponseDto(brewedCoffee.Message, brewedCoffee.Prepared));
        }
    }
}
