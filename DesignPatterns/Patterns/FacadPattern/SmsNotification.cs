using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Of_Facada_Pattern
{
    public class SmsNotification
    {
public void Send(string to , string msg)
        {
            Console.WriteLine($"{msg} {to}");
        }

    }
}
