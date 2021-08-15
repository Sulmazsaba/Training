using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Mediator
{
  public  class Button : UiControl
  {
      private bool _isEnabled;
        public Button(DialogBox owner) : base(owner)
        {
        }

        public void SetIsEnabled(bool isEnabled)
        {
            _isEnabled = isEnabled;

            owner.Changed(this);
        }


        public bool GetIsEnabled()
        {
            return _isEnabled;
        }
    }
}
