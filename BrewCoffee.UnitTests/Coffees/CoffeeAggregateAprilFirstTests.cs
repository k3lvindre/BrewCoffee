using BrewCoffee.Core.Aggregates.CoffeeAggregate;
using BrewCoffee.Core.Common.Exceptions;
using FluentAssertions;
using NUnit.Framework;

namespace BrewCoffee.UnitTests.Coffees
{
    [TestFixture]
    public class CoffeeAggregateAprilFirstTests
    {
        [Test]
        public void Brew_OnAprilFirst_ShouldThrowBusinessException()
        {
            // Arrange
            var coffee = new Coffee();
            var aprilFirst = new DateTime(DateTime.UtcNow.Year, 4, 1);

            // Act
            var act = () => coffee.Brew(aprilFirst, 20);

            // Assert
            act.Should().Throw<BusinessException>();
        }
    }
}
