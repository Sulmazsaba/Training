using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Proxy
{
   public class Library
   {
       private Dictionary<string,IEBook> _eBooks=new Dictionary<string, IEBook>();

       public void AddEBook(IEBook eBook)
       {
           _eBooks.Add(eBook.GetFileName(),eBook);
       }

       public void OpenEBook(string fileName)
       {
       
           _eBooks[fileName].Show();
       }
   }
}
