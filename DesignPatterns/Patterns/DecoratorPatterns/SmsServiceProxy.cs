using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Of_Decorator
{
    public class SmsServiceProxy
    {

        // to create object and count number of messages

        private SmsService _smsservice;

        Dictionary<string, int> count = new Dictionary<string, int>();

        public SmsServiceProxy()
        {
            _smsservice = new ConcretSmsService();
        }
        public string SendSms(string id, string mobile, string sms)
        {
            //create object

            // first call
            if (!count.ContainsKey(id))
            {
                count.Add(id, 1);
                return _smsservice.SendSms(id, mobile, sms);
            }
            //became 2
            else
            {
                //var customer=count.Where(x=>x.Key==id).FirstOrDefault(); 
                if (count[id] >= 2)
                {
                    return "Not Send!";
                }
                // add to value 1
                else
                {
                    count[id] += 1;

                    return _smsservice.SendSms(id, mobile, sms);
                }

            }





        }
    }
}
