using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Of_Decorator
{
    public class NotificatonEmailSevice:AbstractDecorator
    {
        protected SmsService SmsService;
        public NotificatonEmailSevice(SmsService SmsService):base(SmsService)
        {
            this.SmsService = SmsService;
        }

        public string SendSmsNotification(string id, string sms)
        {
            return $"sms {sms} send to {id}, at {DateTime.Now.ToLongDateString()}";
        }
        public override string SendSms(string id, string mobile, string sms)
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(base.SendSms(id, mobile, sms));

            result.AppendLine(SendSmsNotification(id, sms));  
            return result.ToString();   
        }




















    }
}
