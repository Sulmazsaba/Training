using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Strategy
{
    public static class StrategyTester
    {
        public static void Test()
        {
            ImageStorage imageStorage = new ImageStorage(
                new BlackAndWhiteFilter(),
                new JPegCompressor());
            imageStorage.Store("newFile1");
        }
    }
}
