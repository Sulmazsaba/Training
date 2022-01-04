using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.FactoryMethod
{
   public abstract class Delivery
   {

       public abstract IVehicle MakeVehicle();

       public void Handle()
       {
           var vehicle = MakeVehicle();
           vehicle.Move();
       }

   }
}
