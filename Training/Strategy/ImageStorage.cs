using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Strategy
{
   public class ImageStorage
   {
       private IFilter _filter;
       private ICompressor _compressor;

       public ImageStorage(IFilter filter, ICompressor compressor)
       {
           _filter = filter;
           _compressor = compressor;
       }


       public void Store(string fileName)
        {
            _filter.Apply();
            _compressor.Compress();
        }
    }
}
