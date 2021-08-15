using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Visitor
{
   public interface IOperation
   {
       void Apply(HeadingNode headingNode);
       void Apply(AnchorNode anchorNode);
   }
}
