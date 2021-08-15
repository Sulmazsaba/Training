using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Decorator
{
   public class EncryptedStream : IStream
   {
       private IStream _stream;

       public EncryptedStream(IStream stream)
       {
           _stream = stream;
       }

       public void Write(string data)
       {
           var encryptedData = Encrypt(data);
           _stream.Write(encryptedData);
       }

       public string Encrypt(string data)
       {
           return $"Encrypted {data}";
       }



   }
}
