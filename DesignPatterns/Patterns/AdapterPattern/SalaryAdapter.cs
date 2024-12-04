using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Of_Adapter
{
    public class SalaryAdapter:SalaryCalc
    {
        private Employee _employee;

public double SalaryCalc(MachineOperator machineOperator)
        {
            _employee=new Employee();
            _employee.BasicSalary = machineOperator.BasicSalary;
            return base.salarycalc(_employee);
        }






















    }
}
