using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Flyweight
{
   public class PointIcon
   {
       public PointType Type { get; }
       public byte[] Icon { get; }

        public PointIcon(PointType pointType, byte[] icon)
        {
            Type = pointType;
            Icon = icon;
        }
   }
}
