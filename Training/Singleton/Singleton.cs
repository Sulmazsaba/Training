using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Singleton
{
   public class Singleton
   {
       private static Singleton _instance;
       public string Name { get; set; }
        private  Singleton()
        {
            
        }


        public static Singleton GetInstance()
        {
            return _instance ??= new Singleton();
        }


    }
}
