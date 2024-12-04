// See https://aka.ms/new-console-template for more information
using Example_Of_Prototype;

namespace Example_Of_pPrototype
{


    public class oop
    {



        public static void Main(string[] args)
        {

            EmployeePrototype Tempemp1 = new TempEmployee();
            Tempemp1.Name = "Ayman Hesham";
            Tempemp1.Id = 1;
            Tempemp1.EmpAddress = new Address { City = "Man", StreetName = "Mansour", Buliding = "123" };
            EmployeePrototype Tempemp2 = Tempemp1.ShallowCopy();
            Console.WriteLine("information about Tempemp1");
            Console.WriteLine(Tempemp1.ToString());
            Console.WriteLine("information about Tempemp2");
            Console.WriteLine(Tempemp2.ToString());
            Tempemp2.EmpAddress.City = "Cairo";
            Tempemp2.Name = "Reem Eldafrawy";
            Console.WriteLine("information about Tempemp1 After change");
            Console.WriteLine(Tempemp1.ToString());
            Console.WriteLine("information about Tempemp2 After change");
            Console.WriteLine(Tempemp2.ToString());
            Console.WriteLine(Tempemp1.Name);





























        }









    }
}
