using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.ChainOfResponsibility
{
   public abstract class Handler
   {
       private Handler _next;

       protected Handler(Handler next)
       {
           _next = next;
       }


       public void Handle()
       {
           if (!DoHandle())
               return;

           if(_next!=null)
           {
               _next.Handle();
           }
       }

       public abstract bool DoHandle();

   }
}
