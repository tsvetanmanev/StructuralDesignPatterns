namespace FacadeExample.CarFacede
{
    using FacadeExample.CarSystem;

    public class CarFacade
    {
        private readonly CarModel model;
        private readonly CarEngine engine;
        private readonly CarBody body;
        private readonly CarAccessories accessories;

        public CarFacade()
        {
            model = new CarModel();
            engine = new CarEngine();
            body = new CarBody();
            accessories = new CarAccessories();
        }

        public void CreateCar()
        {
            System.Console.WriteLine("*******Creating a Car*******");
            model.SetModel();
            engine.SetEngine();
            body.SetBody();
            accessories.SetAccessories();

            System.Console.WriteLine("************Car creation is complete***********");
        }
    }
}
