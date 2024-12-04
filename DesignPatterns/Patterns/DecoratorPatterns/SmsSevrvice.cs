using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Of_Decorator
{
    public abstract class SmsService
    {
        public abstract string SendSms(string id, string mobile, string sms);
    }
}
