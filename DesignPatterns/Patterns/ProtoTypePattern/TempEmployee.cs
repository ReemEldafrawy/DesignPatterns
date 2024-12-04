using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Of_Prototype
{
    public class TempEmployee:EmployeePrototype
    {


        public override EmployeePrototype ShallowCopy()
        {
            return (TempEmployee)this.MemberwiseClone();
        }
        public override EmployeePrototype DeepCopy()
        {
            TempEmployee emp = new TempEmployee();
            emp=(TempEmployee)this.MemberwiseClone();
            emp.EmpAddress = new Address
            {
                Buliding = EmpAddress.Buliding,
                StreetName = EmpAddress.StreetName,
                City = EmpAddress.City,

            };
            emp.Name= this .Name;
            return emp;
        }


























    }
}
