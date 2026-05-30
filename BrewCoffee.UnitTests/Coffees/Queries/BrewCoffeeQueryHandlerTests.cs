using BrewCoffee.Application.Coffees.Queries.BrewCoffeeQuery;
using FluentAssertions;
using NUnit.Framework;

namespace BrewCoffee.UnitTests.Coffees.Queries
{
    [TestFixture]
    public class BrewCoffeeQueryHandlerTests
    {
        private readonly BrewCoffeeQueryHandler _handler;

        public BrewCoffeeQueryHandlerTests()
        {
            _handler = new BrewCoffeeQueryHandler(new WeatherServiceMoq(20));
        }

        [Test]
        public async Task Handle_WhenBrewIsOkay_ShouldReturnBrewedCoffeeResponse()
        {
            // Arrange
            var query = new BrewCoffeeQuery();
            var cancellationToken = CancellationToken.None;

            // Act
            var result = await _handler.Handle(query, cancellationToken);

            // Assert
            result.Should().NotBeNull();
            result.Message.Should().Be("Your piping hot coffee is ready");
            result.Prepared.Should().BeCloseTo(DateTime.UtcNow, TimeSpan.FromSeconds(1));
        }

        [Test]
        public async Task Handle_WhenBrewIsOkay_MessageShouldBePipingHot()
        {
            // Arrange
            var query = new BrewCoffeeQuery();
            var cancellationToken = CancellationToken.None;

            // Act
            var result = await _handler.Handle(query, cancellationToken);

            // Assert
            result.Message.Should().Contain("piping hot coffee");
        }


        [Test]
        public async Task Handle_WhenCancellationTokenIsPassed_ShouldNotThrowException()
        {
            // Arrange
            var query = new BrewCoffeeQuery();
            var cts = new CancellationTokenSource();

            // Act
            var act = async () => await _handler.Handle(query, cts.Token);

            // Assert
            await act.Should().NotThrowAsync();
        }

        [Test]
        public async Task Handle_ShouldReturnResponseWithUtcDateTime()
        {
            // Arrange
            var query = new BrewCoffeeQuery();
            var cancellationToken = CancellationToken.None;

            // Act
            var result = await _handler.Handle(query, cancellationToken);

            // Assert
            result.Prepared.Kind.Should().Be(DateTimeKind.Utc);
        }
    }
}
