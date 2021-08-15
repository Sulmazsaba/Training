using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Composite
{
   public static class CompositeTester
    {
        public static void Test()
        {
            var org = new CompoundOrgan("main org");
            
            var hr = new SimpleOrgan("hr");
            var it = new CompoundOrgan("IT department");
            it.AddChild(new SimpleOrgan("CTo"));
            it.AddChild(new SimpleOrgan("CEo"));
            org.AddChild(hr);
            org.AddChild(it);

           Console.WriteLine(org.GetInfo());
           Console.ReadKey();
        }
    }
}
