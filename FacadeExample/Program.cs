namespace FacadeExample
{
    using FacadeExample.CarFacede;

    class Program
    {
        static void Main(string[] args)
        {
            var facade = new CarFacade();

            facade.CreateCar();
        }
    }
}
