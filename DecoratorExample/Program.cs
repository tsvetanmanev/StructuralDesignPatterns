namespace DecoratorExample
{
    using System;
    using DecoratorExample.Decorators;
    using DecoratorExample.Seats;

    public class Program
    {
        public static void Main(string[] args)
        {
            FlightSeat normalSeat = new FlightSeat();
            Console.WriteLine("Normal seat parameters:");
            PrintFacilities(normalSeat);
            Console.WriteLine(string.Format("Total cost: {0}", normalSeat.GetCost()));
            Console.WriteLine("**************");

            WifiFlightSeatDecorator seatWithWifi = new WifiFlightSeatDecorator(normalSeat);
            Console.WriteLine("Seat With Wifi parameters:");
            PrintFacilities(seatWithWifi);
            Console.WriteLine(string.Format("Total cost: {0}", seatWithWifi.GetCost()));

            TvFligthSeatDecorator seatWithWifiAndTv = new TvFligthSeatDecorator(seatWithWifi);
            Console.WriteLine("Seat with Wifi and TV parameters:");
            PrintFacilities(seatWithWifiAndTv);
            Console.WriteLine(string.Format("Total cost: {0}", seatWithWifiAndTv.GetCost()));
        }

        public static void PrintFacilities(IFlightSeat flightSeat)
        {
            var facilities = flightSeat.GetFacilities();
            foreach (var facility in facilities)
            {
                Console.WriteLine(string.Format("------{0}", facility));
            }
        }
    }
}
