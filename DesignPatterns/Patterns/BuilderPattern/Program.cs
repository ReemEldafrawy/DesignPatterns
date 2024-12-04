// See https://aka.ms/new-console-template for more information
namespace Example_Of_Bulider
{


    public class oop
    {




        public static void Main(String[] args)
        {

Director director = new Director();
 IBuilder builder1 = new Car("Jeep");
            IBuilder builder2 = new Bike("Nona");
            director.Construct(builder1);
            Product car = builder1.GetProduct();
            Console.WriteLine($"Details : { car.show()}");


             director.Construct(builder2);
            Product bike = builder2.GetProduct();
            Console.WriteLine($"Details:{bike.show()}");














        }































    }
}
