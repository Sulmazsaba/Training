using System;

namespace Training.Visitor
{
    public class HighlightOperation : IOperation
    {
        public void Apply(HeadingNode headingNode)
        {
            Console.WriteLine("highlighting headingNode");
        }

        public void Apply(AnchorNode anchorNode)
        {
            Console.WriteLine("highlighting anchorNode");
        }
    }
}