using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Mediator
{
  public  class ListBox : UiControl
  {
      public string _selection;

      public ListBox(DialogBox owner) : base(owner)
        {
        }


        public void SetSelection(string selection)
        {
            _selection = selection;
            owner.Changed(this);
        }

    }
}
