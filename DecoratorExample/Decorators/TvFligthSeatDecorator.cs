namespace DecoratorExample.Decorators
{
    using System;
    using System.Collections.Generic;
    using DecoratorExample.Seats;
    
    public class TvFligthSeatDecorator : FlightSeatDecorator
    {
        public const double TvCost = 40;
        public const string TvText = "TV";

        public TvFligthSeatDecorator(IFlightSeat flightSeat) : base(flightSeat)
        {
            this.FlightSeat.GetFacilities().Add(TvText);
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
            return originalFacilities;
        }
    }
}
