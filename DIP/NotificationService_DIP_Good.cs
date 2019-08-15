using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWay.DIP
{
    public class Email
    {
        public string ToAddress { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public void SendEmail()
        {
            //Send email
        }
    }

    public class SMS
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public void SendSMS()
        {
            //Send sms
        }
    }
    class NotificationService_DIP_Bad
    {

        private Email _email;
        private SMS _sms;
        public NotificationService_DIP_Bad()
        {
            _email = new Email();
            _sms = new SMS();
        }

        public void Send()
        {
            _email.SendEmail();
            _sms.SendSMS();
        }

    }
}
