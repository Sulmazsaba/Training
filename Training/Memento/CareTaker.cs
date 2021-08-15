using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Memento
{
   public class CareTaker
   {
       private List<Memento> _mementos = new List<Memento>();

       public void Push(Memento memento)
       {
           _mementos.Add(memento);
       }

       public Memento Pop()
       {
           var lastMemento = _mementos[_mementos.Count - 1];
           _mementos.Remove(lastMemento);

           return lastMemento;
       }
   }
}
