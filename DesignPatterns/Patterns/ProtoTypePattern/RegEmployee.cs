using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Of_Prototype
{
    public class RegEmployee:EmployeePrototype
    {

        public override EmployeePrototype ShallowCopy()
        {
            return  (RegEmployee)this.MemberwiseClone();
        }

        public override EmployeePrototype DeepCopy()
        {
           RegEmployee emp = new RegEmployee();
            emp=(RegEmployee)this.MemberwiseClone();
            emp.EmpAddress = new Address
            {
                City = EmpAddress.City,
                StreetName = EmpAddress.StreetName,
                Buliding = EmpAddress.Buliding,
            };
                emp.Name = this.Name;
            return emp;

        }




    }
}
