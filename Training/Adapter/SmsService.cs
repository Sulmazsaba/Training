using System;

namespace Training.Adapter
{
    public class SmsService 
    {
        public void Login()
        {
            Console.WriteLine("Login Sms");

        }

        public void SetPort()
        {
            Console.WriteLine("Set Port for sending SMS...");
        }

        public void SendSms()
        {
            Console.WriteLine("Sending SMS...");
        }
    }
}