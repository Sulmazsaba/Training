using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Decorator
{
   public class CompressedStream : IStream
   {

       private IStream _stream;

       public CompressedStream(IStream stream)
       {
           _stream = stream;
       }

       public void Write(string data)
       {
           var compressedData = Compress(data);
           _stream.Write(compressedData);
       }

       public string Compress(string data)
       {
           return $"Compressed {data}";
       }
    }
}
