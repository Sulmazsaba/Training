using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Visitor
{
  public static class VisitorTester
    {

        public static void Test()
        {
            IHtmlNode headingNode= new HeadingNode();
            headingNode.Execute(new HighlightOperation());


            Console.ReadKey();
        }
    }
}
