using System.Collections.Generic;
using System.Linq;

namespace Training.Observer
{
  public  class DataSource : Subject
  {

      private int _value;

      public int Value
      {
          get => _value;
          set
          { 
              _value = value;
              Notify();
          }
      }


  }


 
}


