namespace DecoratorExample.Decorators
{
    using System;
    using DecoratorExample.FlightSeat;
    using System.Collections.Generic;
    public abstract class FlightSeatDecorator : IFlightSeat
    {
        public IFlightSeat FlightSeat { get; private set; }

        public FlightSeatDecorator(IFlightSeat flightSeat)
        {
            this.FlightSeat = flightSeat;
        }

        public abstract double GetCost();

        public abstract ICollection<string> GetFacilities();
    }
}
