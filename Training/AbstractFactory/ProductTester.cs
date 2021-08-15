using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.AbstractFactory
{
   public class ProductTester
    {
        public void Test(IFactory factory)
        {
           var smartPhone= factory.CreateSmartPhone();

           var tablet = factory.CreateTablet();


           smartPhone.Ring();
           smartPhone.SwitchOn();

           tablet.SwitchOn();
        }

    }
}
