using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Adapter
{
   public static class AdapterTester
    {
        public static void Test()
        {
            var notification = new XyzSmsAdapter(new SmsService());
           
            Notify(notification);

            var slackNotif=new XyzSlackAdapter(new SlackService());
            Notify(slackNotif);

            Console.ReadKey();
        }


        public static void Notify(INotification notification)
        {
            notification.Send();
        }
    }
}
