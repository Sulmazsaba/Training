using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace Training.Template
{
  public  class AuditLogger
    {
        public void Log(string messag)
        {
            Console.WriteLine($"audit logging {messag}");
        }
    }
}
