using System;

namespace Training.Adapter
{
    public class XyzSmsAdapter : INotification
    {
        private SmsService _smsService;

        public XyzSmsAdapter(SmsService smsService)
        {
            _smsService = smsService;
        }

        public void Send()
        {
            _smsService.Login();
            _smsService.SetPort();
            _smsService.SendSms();
        }
    }
}