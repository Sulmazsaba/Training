using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Facade
{
  public  class NotificationService
    {
        public void Send(string message,string target)
        {
            var server = new NotificationServer();
            var connection = server.Connect("ip");
            var authToken = server.Authenticate("AppId", "key");
            server.Send(new Message(message),target,authToken);

            connection.Disconnect();

        }
    }
}
