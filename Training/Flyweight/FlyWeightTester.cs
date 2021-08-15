using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Flyweight
{
    public static class FlyWeightTester
    {
     public static void Test()
        {
            PointService pointService = new PointService(new PointIconFactory());
           var points = pointService.GetPoints();

           foreach(var point in points)
               point.Draw();


           Console.ReadKey();
        }
    }
}
