using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.State
{
    public abstract  class State
    {
        protected Context _context;

        public void SetContext(Context context)
        {
            _context = context;
        }

       public abstract void  DoThis();
      public abstract void DoThat();
    }
}
