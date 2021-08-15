using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.AbstractFactory
{
   public interface IFactory
    {
        ISmartPhone CreateSmartPhone();
        ITablet CreateTablet();
    }
}
