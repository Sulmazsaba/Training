﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Decorator
{
  public  class CloudStream : IStream
    {
        public void Write(string data)
        {
            Console.WriteLine(data);
        }
    }
}
