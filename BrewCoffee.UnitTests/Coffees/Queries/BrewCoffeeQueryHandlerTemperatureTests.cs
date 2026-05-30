using BrewCoffee.Application.Coffees.Queries.BrewCoffeeQuery;
using FluentAssertions;
using NUnit.Framework;

namespace BrewCoffee.UnitTests.Coffees.Queries
{
    [TestFixture]
    public class BrewCoffeeQueryHandlerTemperatureTests
    {
        [Test]
        public async Task Handle_TemperatureAbove30_ShouldReturnIcedCoffeeMessage()
        {
            // Arrange
            var weatherService = new WeatherServiceMoq(31);
            var handler = new BrewCoffeeQueryHandler(weatherService);
            var query = new BrewCoffeeQuery();

            // Act
            var result = await handler.Handle(query, CancellationToken.None);

            // Assert
            result.Should().NotBeNull();
            result.Message.Should().Contain("iced coffee");
        }

        [Test]
        public async Task Handle_TemperatureAtOrBelow30_ShouldReturnPipingHotCoffeeMessage()
        {
            // Arrange
            var weatherService = new WeatherServiceMoq(20);
            var handler = new BrewCoffeeQueryHandler(weatherService);
            var query = new BrewCoffeeQuery();

            // Act
            var result = await handler.Handle(query, CancellationToken.None);

            // Assert
            result.Should().NotBeNull();
            result.Message.Should().Contain("piping hot coffee");
        }
    }
}
