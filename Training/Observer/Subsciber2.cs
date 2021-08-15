using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Observer
{
    public class Subscriber2 : ISubscriber
    {
        
        private readonly DataSource _dataSource;

        public Subscriber2(DataSource dataSource)
        {
            this._dataSource = dataSource;
        }
        public string Name { get; set; }

        public void Update()
        {
            Console.WriteLine($" {Name} value is {_dataSource.Value}");
        }
    }
}
