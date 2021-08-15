using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Facade
{
   public  static class TestFacade
    {
        public static void Test()
        {
            NotificationService service=new NotificationService();
            service.Send("salam","target");
        }
    }
}
