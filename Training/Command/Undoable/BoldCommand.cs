﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Command.Undoable
{
    class BoldCommand : IUndoableCommand
    {
        private string _prevContent;
        private HtmlDocument _document;
        private History _history;

        public BoldCommand(HtmlDocument document, History history)
        {
            _document = document;
            _history = history;
        }


        public void Execute()
        {
            _prevContent = _document.Content;

            _document.Bold();

            _history.Push(this);
            
        }

        public void UnExecute()
        {
            _document.Content = _prevContent;
        }
    }
}
