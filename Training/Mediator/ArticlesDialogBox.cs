using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Mediator
{
    public class ArticlesDialogBox : DialogBox
    {
        private ListBox _articleListBox;
        private Button _saveButton;
        private TextBox _titleTextBox;

        public ArticlesDialogBox()
        {
            _articleListBox = new ListBox(this);
            _titleTextBox = new TextBox(this);
            _saveButton = new Button(this);
        }

        public void SimulateUserInteraction()
        {
            _articleListBox.SetSelection("first item");

                Console.WriteLine($"Text box content:{_titleTextBox._content}");
                Console.WriteLine($"button enabled:{_saveButton.GetIsEnabled()}");
        }

        public override void Changed(UiControl uIControl)
        {
            if (uIControl == _articleListBox)
            {
                _titleTextBox.SetContent(_articleListBox._selection);
                _saveButton.SetIsEnabled(true);

            }
            else if (uIControl == _titleTextBox)
            {
                var isEmpty = String.IsNullOrEmpty(_titleTextBox._content);
                _saveButton.SetIsEnabled(!isEmpty);
            }


        }
    }
}
