using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.ChainOfResponsibility
{
  public static  class ChainOfResponsibilityTester
    {

        public static void Test()
        {
            WebServer webServer = new WebServer();
            webServer.Handle("salam");
        }
    }
}
