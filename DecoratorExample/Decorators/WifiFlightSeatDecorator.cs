namespace DecoratorExample.Decorators
{
    using System.Collections.Generic;
    using DecoratorExample.Seats;

    public class WifiFlightSeatDecorator : FlightSeatDecorator
    {
        public const int WifiCost = 20;
        public const string WiFiText = "WiFi addon";
        
        public WifiFlightSeatDecorator(IFlightSeat flightSeat) : base(flightSeat)
        {
            this.FlightSeat.GetFacilities().Add(WiFiText);
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
            return originalFacilities;
        }
    }
}
