using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Mediator
{
   public class TextBox : UiControl
   {
       public string _content;
        public TextBox(DialogBox owner) : base(owner)
        {
        }

        public void SetContent(string content)
        {
            _content = content;
            owner.Changed(this);
        }



    }
}
