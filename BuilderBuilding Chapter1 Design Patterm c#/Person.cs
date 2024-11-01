using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderBuilding_Chapter1_Design_Patterm_c_
{
    internal class Person
    {
        public Address _Address { get; set; } = new Address(); 
        public EmployeeInfo _EmployeeInfo { get; set; } = new EmployeeInfo();
    }
}
