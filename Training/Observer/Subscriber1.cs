using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Observer
{
  public  class Subscriber1 : ISubscriber
  {
      private readonly DataSource dataSource;

      public Subscriber1(DataSource dataSource)
      {
          this.dataSource = dataSource;
      }

      public string Name { get; set; }

      public void Update()
      {
          Console.WriteLine($" {Name} value is {dataSource.Value}");
      }
  }
}
