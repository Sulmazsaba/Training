using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Memento
{
  public  class Originator
  {

      public string Content { get; set; }

      public Memento CreateMemento()
      {
          return  new Memento(Content);
      }

      public void RestoreMemento(Memento memento)
      {
          Content = memento.Content;
      }
  }
}
