using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Bridge
{
   public interface IDevice
   {
       void TurnOn();
       void TurnOff();
       void SetChannel(int number);
   }
}
