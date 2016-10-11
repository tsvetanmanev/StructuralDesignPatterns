namespace DecoratorExample.Seats
{
    using System;
    using System.Collections.Generic;

    public class FlightSeat : IFlightSeat
    {
        public const double StandardPrice = 500;
        public const string FlightSeatText = "Cabin Seat";

        private ICollection<string> facilities;

        public FlightSeat()
        {
            this.Facilities = new List<string>();
            this.Facilities.Add(FlightSeatText);
        }

        public ICollection<string> Facilities
        {
            get
            {
                return this.facilities;
            }

            private set
            {
                this.facilities = value;
            }
        }

        public double GetCost()
        {
            var seatCost = StandardPrice;
            return seatCost;
        }

        public ICollection<string> GetFacilities()
        {
            return this.Facilities;
        }
    }
}
