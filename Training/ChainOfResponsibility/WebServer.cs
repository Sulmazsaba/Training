using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.ChainOfResponsibility
{
    public class WebServer
    {
        public void Handle(string request)
        {
            var compressor = new Compressor(null);
            var authenticator = new Authenticator(compressor);
            var logger = new Logger(authenticator);

            logger.Handle();

            Console.ReadLine();

        }


    }
}
