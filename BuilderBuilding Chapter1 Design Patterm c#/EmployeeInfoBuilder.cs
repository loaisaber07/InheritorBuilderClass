using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderBuilding_Chapter1_Design_Patterm_c_
{
    internal class EmployeeInfoBuilder : PersonBuilder
    {
        public EmployeeInfoBuilder(Person _person) : base(_person)
        {
            this.person = _person;
        }
    }
}
