using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Iterator
{
    interface IIterator
    {
        bool HasNext();

        object Current();
        void Next();

    }
}
