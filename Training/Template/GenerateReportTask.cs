﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Template
{
  public  class GenerateReportTask : Task
    {

        protected override void DoExecute()
        {
            Console.WriteLine("executing generating report");
        }
    }
}
