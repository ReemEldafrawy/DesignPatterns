﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Example_Of_Prototype
{

    /*
     * Copy Heavy Initialization Objects Instead of Creating
     * */
    public abstract class EmployeePrototype
    {
public int Id { get; set; }
public string Name { get; set; }
public Address EmpAddress { get; set; }

        public abstract EmployeePrototype ShallowCopy();

        public abstract EmployeePrototype DeepCopy();


        public override string ToString()
        {
            return
                $@"
Id={this.Id}
Name={this.Name}
Address={this.EmpAddress.City},{this.EmpAddress.StreetName},{this.EmpAddress.Buliding}



";
        }



















    }
}
