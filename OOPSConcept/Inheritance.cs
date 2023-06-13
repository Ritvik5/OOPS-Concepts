using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    // -- Single Level Inheritance
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }

    public class Employee : Person
    {
        public int EmployeeId { get; set; }
        public string CompanyName { get; set; }
    }

}
