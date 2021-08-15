using System;

namespace Training.Strategy
{
    public class PngCompressor : ICompressor
    {
        public void Compress()
        {
            Console.WriteLine("Compressing PNG..");
        }
    }
}