using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Decorator
{
   public static class DecoratorTester
    {

        public static void Test()
        {
            var compressedStream =new EncryptedStream(new CompressedStream(new CloudStream()));
           

            //var decorator = new EncryptedStream(compressedStream);
            //decorator.Write("Hallo!");
            compressedStream.Write("High");


            Console.ReadKey();
        }
    }
}
