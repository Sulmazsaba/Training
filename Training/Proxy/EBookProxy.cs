using System;

namespace Training.Proxy
{
    public class EBookProxy : IEBook
    {
        private string _fileName;
        private RealEBook _eBook;

        public EBookProxy(string fileName)
        {
            _fileName = fileName;
        }

        public void Show()
        {
            // lazy loading
            if(_eBook==null)
                _eBook= new RealEBook(_fileName);

            _eBook.Show();

        }

        public string GetFileName()
        {
            return _fileName;
        }
    }
}