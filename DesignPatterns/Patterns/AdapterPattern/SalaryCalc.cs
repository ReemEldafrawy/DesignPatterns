using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Of_Adapter
{
    public class SalaryCalc
    {
        public double salarycalc(Employee emp)
            {
            return emp.BasicSalary * 1.5;

        }
    }
}
