namespace DecoratorExample.Decorators
{
    using System;
    using DecoratorExample.FlightSeat;
    using System.Collections.Generic;
    public class TvFligthSeatDecorator : FlightSeatDecorator
    {
        public const double TvCost = 40;
        public const string TvText = "TV";

        public TvFligthSeatDecorator(IFlightSeat flightSeat) : base(flightSeat)
        {
        }
        
        public override double GetCost()
        {
            var originalCost = this.FlightSeat.GetCost();
            var decoratedCost = originalCost + TvCost;
            return decoratedCost;
        }

        public override ICollection<string> GetFacilities()
        {
            var originalFacilities = this.FlightSeat.GetFacilities();
            originalFacilities.Add(TvText);
            return originalFacilities;
        }
    }
}
