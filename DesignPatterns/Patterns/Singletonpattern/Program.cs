// See https://aka.ms/new-console-template for more information
namespace Example_Of_Singleton
{


    public class oop
    {


        public static void Main(String[] args)
        {
           
            
                Counter counter1 = Counter.GetInstance();
                counter1.AddCount();
                Console.WriteLine($"Counter 1 : {counter1.Count}");
                Counter counter2 = Counter.GetInstance();
                counter2.AddCount();
                Console.WriteLine($"Counter 2: {counter2.Count}");


            counter2.AddCount();
            Console.WriteLine($"Counter 1 : {counter1.Count}");
            Console.WriteLine($"Counter 2: {counter2.Count}");

            counter1.AddCount();
            Console.WriteLine($"Counter 1 : {counter1.Count}");
            Console.WriteLine($"Counter 2: {counter2.Count}");















        }






























    }
}
