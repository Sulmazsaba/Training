using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Flyweight
{
   public class Point
    {
        private int _x;
        private int _y;
        private PointIcon _pointIcon;

        public Point(int x, int y, PointIcon pointIcon)
        {
            _x = x;
            _y = y;
            _pointIcon = pointIcon;
        }

        public void Draw()
        {
            Console.WriteLine($"x : {_x} , y : {_y} , type : {_pointIcon.Type} ");
        }


    }
}
