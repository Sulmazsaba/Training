using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Facade
{
  public  class NotificationServer
    {
        
        public Connection Connect(string ip)
        {
            return new Connection();
        }

        public AuthToken Authenticate(string appId, string key)
        {
            return new AuthToken();
        }


        public void Send(Message message, string target, AuthToken token)
        {
            Console.WriteLine("sending message");
        }
    }
}
