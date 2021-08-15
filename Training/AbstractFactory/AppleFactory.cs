namespace Training.AbstractFactory
{
    class AppleFactory : IFactory
    {
        public ISmartPhone CreateSmartPhone()
        {
            return new AppleSmartPhone();
        }

        public ITablet CreateTablet()
        {
            return new AppleTablet();

        }
    }
}