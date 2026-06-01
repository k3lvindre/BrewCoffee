using BrewCoffee.Core.Common.Exceptions;

namespace BrewCoffee.Core.Aggregates.CoffeeAggregate
{
    public class Coffee 
    {
        public string Message { get; set; } = string.Empty;
        public DateTime Prepared { get; set; }

        private readonly DateTime FirstDayOfApril = new(DateTime.UtcNow.Year, 4, 1);


        public Coffee Brew(DateTime dateToday)
        {
            //invariant: we don't brew coffee on April 1st, it's a day for jokes, not for coffee
            if (dateToday == FirstDayOfApril) throw new BusinessException();

            this.Message = "Your piping hot coffee is ready";
            this.Prepared = dateToday;
            return this;
        }
    }
}
