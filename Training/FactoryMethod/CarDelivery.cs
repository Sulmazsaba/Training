namespace Training.FactoryMethod
{
    public class CarDelivery : Delivery
    {
        public override IVehicle MakeVehicle()
        {
            return new Car();
        }
    }
}