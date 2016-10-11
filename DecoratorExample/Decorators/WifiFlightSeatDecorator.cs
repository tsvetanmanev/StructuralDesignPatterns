using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorExample.FlightSeat;

namespace DecoratorExample.Decorators
{
    public class WifiFlightSeatDecorator : FlightSeatDecorator
    {
        public const int WifiCost = 20;
        public const string WiFiText = "WiFi addon";
        
        public WifiFlightSeatDecorator(IFlightSeat flightSeat) : base(flightSeat)
        {

        }

        public override double GetCost()
        {
            var originalCost = this.FlightSeat.GetCost();
            var decoratedCost = originalCost + WifiCost;
            return decoratedCost;
        }

        public override ICollection<string> GetFacilities()
        {
            var originalFacilities = this.FlightSeat.GetFacilities();
            originalFacilities.Add(WiFiText);
            return originalFacilities;
        }
    }
}
