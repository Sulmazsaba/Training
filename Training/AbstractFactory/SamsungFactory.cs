namespace Training.AbstractFactory
{
    public class SamsungFactory : IFactory
    {
        public ISmartPhone CreateSmartPhone()
        {
            return new SamsungSmartPhone();
        }

        public ITablet CreateTablet()
        {
            return new SamsungTablet();
        }
    }
}