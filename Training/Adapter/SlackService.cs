using System;

namespace Training.Adapter
{
    public class SlackService    
    {
        public void Login()
        {
            Console.WriteLine("Login slack...");
        }

        public void SendMessage()
        {
            Console.WriteLine("Send message via slack");
        }
    }
}