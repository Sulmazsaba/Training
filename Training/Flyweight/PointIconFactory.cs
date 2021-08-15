using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Flyweight
{
  public  class PointIconFactory
  {
        private Dictionary<PointType,PointIcon> _pointIcons= new Dictionary<PointType, PointIcon>();

      public PointIcon GetPointIcon(PointType type)
      {
          if (!_pointIcons.ContainsKey(type))
          {
                _pointIcons.Add(type,new PointIcon(type,null));
          }

          return _pointIcons[type];
      }
    }
}
