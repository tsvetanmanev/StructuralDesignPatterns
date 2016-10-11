using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample.FlightSeat
{
    public class FlightSeat : IFlightSeat
    {
        public const double StandardPrice = 500;
        public const string FlightSeatText = "Cabin Seat";

        private ICollection<string> facilities;

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
            Facilities.Add(FlightSeatText);
            return Facilities;
        }
    }
}
