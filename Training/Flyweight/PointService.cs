using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Flyweight
{
  public  class PointService
  {
      private PointIconFactory _pointIconFactory;

      public PointService(PointIconFactory pointIconFactory)
      {
          _pointIconFactory = pointIconFactory;
      }

      public List<Point> GetPoints()
        {
            List<Point> points= new List<Point>();

            var pointIcon = _pointIconFactory.GetPointIcon(PointType.Cafe);
            var point = new Point(10,14,pointIcon);
            points.Add(point);


            points.Add(new Point(14,33,_pointIconFactory.GetPointIcon(PointType.Hospital)));
            return points;
        }
    }
}
