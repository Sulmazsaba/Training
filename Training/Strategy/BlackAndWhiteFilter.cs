using System;

namespace Training.Strategy
{
    public class BlackAndWhiteFilter : IFilter
    {
        public void Apply()
        {
            Console.WriteLine("applying Black and filter");
        }
    }
}