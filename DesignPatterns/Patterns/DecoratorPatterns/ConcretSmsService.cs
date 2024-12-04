using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Of_Decorator
{
    public class ConcretSmsService:SmsService
    {
        public override string SendSms(string id, string mobile, string sms)
        {
            return $"customer id {id} sms send to {sms}";
        }


    }
}
