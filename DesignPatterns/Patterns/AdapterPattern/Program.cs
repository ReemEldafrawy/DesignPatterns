// See https://aka.ms/new-console-template for more information
namespace Example_Of_Adapter
{


public class oop
    {



        public static void Main(string[] args)
        {




            Employee emp =new Employee();
            emp.Name = "Reem Eldafrawy";
            emp.BasicSalary = 9000;
            SalaryCalc calc = new SalaryCalc();
            Console.WriteLine(calc.salarycalc(emp));
            Console.WriteLine("-----------------------------------------------------");
            MachineOperator machine = new MachineOperator();
            machine.BasicSalary = 7000;
            SalaryAdapter s = new SalaryAdapter();
    
            Console.WriteLine(s.SalaryCalc(machine));















        }



























    }
































}
