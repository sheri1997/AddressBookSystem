using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class ContactBook
    {
        public static List<Person> People = new List<Person>();//List is Defined which will be holding all the collection of array.
        public static Dictionary<string, List<Person>> addressBook = new Dictionary<string, List<Person>>();//Dictionary is defined to hold the colloection of list.
        public static void manyList(string name)
        {
            addressBook.Add(name, People);//this will add a new contact details in t7he address book.
        }
        public static Person NewPerson()//this method will be used a new person in the address book.
        {
            Person person = new Person();//OOPS Concept to manage relationship between Percon Class and main Class
            Console.WriteLine("Please Enter the Frist Name of the Person");
            person.FirstName = Console.ReadLine();
            Console.WriteLine("Please Enter the Last Name of the Person");
            person.LastName = Console.ReadLine();
            Console.WriteLine("Please Enter the Address of the Person");
            person.Address = Console.ReadLine();
            Console.WriteLine("Please Enter theCity of the Person");
            person.City = Console.ReadLine();
            Console.WriteLine("Please Enter theState of the Person");
            person.State = Console.ReadLine();
            Console.WriteLine("Please Enter the Zip Code of the Person");
            person.ZipCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter the Phone Number of the Person");
            person.PhoneNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter the Email Id of the Person");
            person.EmailId = Console.ReadLine();
            People.Add(person);//This will Add the details of the person in the List.
            return person;
        }
        public static void Display(Person person)//method to deisplay the details of the array
        {
            Console.WriteLine("First Name = " + person.FirstName);
            Console.WriteLine("Last Name = " + person.LastName);
            Console.WriteLine("Address = " + person.Address);
            Console.WriteLine("City = " + person.City);
            Console.WriteLine("State = " + person.State);
            Console.WriteLine("Zip Code = " + person.ZipCode);
            Console.WriteLine("Phone Number = " + person.PhoneNumber);
            Console.WriteLine("Email Id = " + person.EmailId);
        }
        public static void Delete()
        {
            Console.WriteLine("Enter the first Name of the Person Which you want to remove");
            string Name = Console.ReadLine();
            Person person = People.FirstOrDefault(x => x.FirstName.ToLower() == Name.ToLower());
            if (person == null)
            {
                Console.WriteLine("Person Not Found");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Person Found");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                People.Remove(person);
                Console.WriteLine("Person Removed");
                Console.ReadKey();
            }
        }
        public static Person equalPerson(List<Person> people,string Name)//this method is used to find the duplicate contact is present or not.
        {
            try
            {
                var contactName = people.Find(p => p.FirstName == Name);//using lambda function to find the name of the contact in the list.
                if(contactName==null)//if the duplicate contact is not found
                {
                    Console.WriteLine("Duplicate Contact is Not Found");
                    return null;
                }
                else//if the duplicate contact is found
                {
                    Console.WriteLine("Duplicate Contact is Found");
                    return contactName;
                }
            }
            catch(Exception ex)//since we dont know which exception is going to be found.
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}