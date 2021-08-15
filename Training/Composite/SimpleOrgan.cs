using System;

namespace Training.Composite
{
    public class SimpleOrgan : IOrgan
    {
        private string _name;

        public SimpleOrgan(string name)
        {
            _name = name;
        }

        public string GetInfo()
        {
            return $"This is {_name}";
        }

        public int GetRevenue()
        {
            throw new NotImplementedException();
        }
    }
}