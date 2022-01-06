using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Observer
{
   public static class TestObserver
    {
        public static void Test()
        {
            DataSource dataSource=new DataSource();

            ISubscriber mahsa = new Subscriber1(dataSource)
            {
                Name = "Mahsan"
            };
            ISubscriber majid = new Subscriber2(dataSource)
            {
                Name = "Majid"
            };

            dataSource.AddSubscriber(mahsa);
            dataSource.AddSubscriber(majid);

            dataSource.Value = 10;

            dataSource.RemoveSubscriber(mahsa);
            dataSource.Value = 5;

            Console.ReadKey();
        }
    }
}
