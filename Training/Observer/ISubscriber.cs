using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Observer
{
   public interface ISubscriber
    {
        
     
        public string Name { get; set; }

        public void Update();
    }
}
