using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Memento
{
    /// <summary>
    /// Behavioral Design Pattern
    /// </summary>
   public class Memento
   {
       public string Content;

       public Memento(string content)
       {
           this.Content = content;
       }


   }
}
