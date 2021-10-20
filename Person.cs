using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class Person//Class To Create a contact Details of the Persons.
    {
        public string FirstName { get; set; }//Will hold the First Name
        public string LastName { get; set; }//Will hold the Last Name
        public string Address { get; set; }//Will hold the Address
        public string City { get; set; }//Will hold the City
        public string State { get; set; }//Will hold the State
        public int ZipCode { get; set; }//Will hold the Zip Code
        public int PhoneNumber { get; set; }//Will hold the Phone Number
        public string EmailId { get; set; }//Will hold the Email ID.
    }
}
