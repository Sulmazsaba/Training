using System;

namespace Training.Strategy
{
    public class JPegCompressor : ICompressor
    {
        public void Compress()
        {
            Console.WriteLine("Compressing JPeg...");
        }
    }
}