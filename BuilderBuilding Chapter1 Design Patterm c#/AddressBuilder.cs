using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderBuilding_Chapter1_Design_Patterm_c_
{
    internal class AddressBuilder : PersonBuilder
    {
        public AddressBuilder(Person person ) :base(person) 
        {
            this.person = person; 
        }
        public AddressBuilder At(string location) {
            person._Address.Location = location;
            return this; 
        }
        public AddressBuilder In(string postCode)
        {
            person._Address.PostCode = postCode;
            return this; 
        }
    }
}
