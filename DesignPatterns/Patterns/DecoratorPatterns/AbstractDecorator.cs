using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Of_Decorator
{
    public abstract class AbstractDecorator:SmsService
    {
        protected SmsService Notification;
        //public void SetService(SmsService Notification)
        //{
        //    this.Notification = Notification;
        //}
        public AbstractDecorator(SmsService notification)
        {
            Notification = notification;
        }
        public override string SendSms(string id, string mobile, string sms)
        {
            if (Notification != null)
            {
                return Notification.SendSms(id, mobile, sms);
            }
            else
            {
                return "Notification Service Not Initialized";
            }
        }

















    }
}
