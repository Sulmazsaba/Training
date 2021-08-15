using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Adapter
{
   public class XyzSlackAdapter : INotification
   {
       private SlackService _slackService;

       public XyzSlackAdapter(SlackService slackService)
       {
           _slackService = slackService;
       }

       public void Send()
        {
            _slackService.Login();
            _slackService.SendMessage();
        }
    }
}
