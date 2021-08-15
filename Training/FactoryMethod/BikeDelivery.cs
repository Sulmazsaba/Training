namespace Training.FactoryMethod
{
    public class BikeDelivery : Delivery
    {
        public override IVehicle MakeVehicle()
        {
            return new Bike();
        }
    }
}