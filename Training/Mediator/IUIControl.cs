using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Mediator
{
   public abstract class UiControl
   {
       protected DialogBox owner;

       protected UiControl(DialogBox owner)
       {
           this.owner = owner;
       }
   }
}
