using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample.FlightSeat
{
    public class FlightSeat : IFlightSeat
    {
        public const int StandardPrice = 500;
        public int GetCost()
        {
            var seatCost = StandardPrice;
            return seatCost;
        }

        public string GetFacilities()
        {
            string seatItself = "Cabin Seat";
            return seatItself;
        }
    }
}
