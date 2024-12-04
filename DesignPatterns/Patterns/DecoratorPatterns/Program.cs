// See https://aka.ms/new-console-template for more information
namespace Example_Of_Decorator
{


    public class oop
    {



        public static void Main(string[] args)
        {

            //SmsServiceProxy proxy = new SmsServiceProxy();
            //Console.WriteLine(proxy.SendSms("123", "01101958909", "Hello Reem"));
            //Console.WriteLine(proxy.SendSms("123", "01101958909", "Hello Reem"));
            //Console.WriteLine(proxy.SendSms("123", "01101958909", "Hello Reem"));

            //Console.WriteLine(proxy.SendSms("123", "01101958909", "Hello Reem"));
            SmsService smsService = new ConcretSmsService();
            NotificatonEmailSevice notificatonEmailSevice = new NotificatonEmailSevice(smsService);
           // notificatonEmailSevice.SetService(smsService);
            Console.WriteLine(notificatonEmailSevice.SendSms("123", "345678900", "Reem Hello"));









        }


























    }




























}

