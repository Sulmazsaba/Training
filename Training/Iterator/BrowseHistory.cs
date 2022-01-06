using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Iterator
{
    class BrowseHistory
    {
        private List<string> _urls = new List<string>();

        public void Push(string url)
        {
            _urls.Add(url);
        }


        public string Pop()
        {
            var index = _urls.Count - 1;
            var lastUrl = _urls[index];

            _urls.RemoveAt(index);

            return lastUrl;
        }

        public IIterator CreateIterator()
        {
            return new ListIterator(this);
        }

        public class ListIterator : IIterator
        {
            private BrowseHistory _history;
            private int index;

            public ListIterator(BrowseHistory browseHistory)
            {
                _history = browseHistory;
            }

            public bool HasNext()
            {
                return index < _history._urls.Count;
            }

            public object Current()
            {
                return _history._urls[index];
            }

            public void Next()
            {
                index++;
            }
        }

    }
}
