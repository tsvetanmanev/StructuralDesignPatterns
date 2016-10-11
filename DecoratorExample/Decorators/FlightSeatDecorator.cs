namespace DecoratorExample.Decorators
{
    using System;
    using System.Collections.Generic;
    using DecoratorExample.Seats;
    
    public abstract class FlightSeatDecorator : IFlightSeat
    {
        public FlightSeatDecorator(IFlightSeat flightSeat)
        {
            this.FlightSeat = flightSeat;
        }

        public IFlightSeat FlightSeat { get; private set; }
        
        public abstract double GetCost();

        public abstract ICollection<string> GetFacilities();
    }
}
