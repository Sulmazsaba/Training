using System;

namespace Training.Strategy
{
    public class HighContractFilter : IFilter
    {
        public void Apply()
        {
            Console.WriteLine("applying high contrast filter...");
        }
    }
}