// See https://aka.ms/new-console-template for more information
namespace Example_Of_Chain_Of_Responsibility
{
    public class oop
    {
        public static void Main(string[] args)
        {

JopApplication application = new JopApplication();
            application.ApplicantName = "Reem Eldafrawy";
            application.JopTitle = "Back End";
            application.JopCode = "00";
            application.Comments=new System.Text.StringBuilder();

            HRHandler hr =new HRHandler();
            TechnalHandler tech = new TechnalHandler();
            hr.SetHandler(tech);
            hr.HandleRequest(application);
          
            Console.WriteLine(application.Comments);











        }
    }
}
