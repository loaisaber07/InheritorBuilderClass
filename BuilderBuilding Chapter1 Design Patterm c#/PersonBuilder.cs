using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderBuilding_Chapter1_Design_Patterm_c_
{
    internal class PersonBuilder
    {
        protected Person person;
        public PersonBuilder()
        {
            person = new Person();
        }
        protected PersonBuilder(Person _person)
        {
            this.person = _person; 
        }
        public AddressBuilder Live => new AddressBuilder(person);
        public EmployeeInfoBuilder Work => new EmployeeInfoBuilder(person);
        public static implicit operator Person(PersonBuilder builder) => builder.person; 
        
    }
}
