namespace DecoratorExample.Seats
{
    using System;
    using System.Collections.Generic;

    public interface IFlightSeat
    {
        ICollection<string> GetFacilities();

        double GetCost();
    }
}
