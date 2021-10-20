using System;
using System.Collections.Generic;
namespace AddressBookSystem
{
    class Program//Address Book Main Class
    {
        public static List<Person> People = new List<Person>();//List is Defined which will be holding all the collection of array.
        static void Main(string[] args)
        {
        }
        private static void NewPerson()//method which wiil hold the Contact Details of a Person.
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
        }
        private static void Display(Person person)//method to deisplay the details of the array
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
    }
}