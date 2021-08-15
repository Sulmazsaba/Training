using System;

namespace Training.Proxy
{
    public class RealEBook : IEBook
    {
        private string _fileName;

        public RealEBook(string fileName)
        {
            _fileName = fileName;
            // in order to show the loading and creating new RealEbook has decreased by
            // adding proxy for creating new RealEbook
            Load();
        }

        public void Show()
        {
            Console.WriteLine($"Showing Ebook with name {_fileName}");
        }

        public string GetFileName()
        {
            return _fileName;
        }

        public void Load()
        {
            Console.WriteLine($"Loading the ebook {_fileName}");
        }
    }
}