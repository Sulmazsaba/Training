using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.State
{
   public class Context
   {
       private State _state;

       public Context(State state)
       {
           ChangeState(state);
       }


       public void ChangeState(State state)
       {
           _state = state;
           _state.SetContext(this);
       }


       public void DoThis()
       {
           _state.DoThis();
       }


       public void DoThat()
       {
           _state.DoThat();
       }
       


   }
}
