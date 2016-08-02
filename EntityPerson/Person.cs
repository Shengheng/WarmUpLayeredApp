using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityPerson
{

    public class PersonLong
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string City { get; set; }

        public string PhoneNumber { get; set; }

        public int Age { get; set; }
    }

    public class PersonShort
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
