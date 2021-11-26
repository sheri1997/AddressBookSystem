using System;
using System.Collections.Generic;
using System.Linq;

namespace AddressBookSystem
{
    class Program//Address Book Main Class
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            Dictionary<string, List<Person>> dict = new Dictionary<string, List<Person>>();
            int num;
            //guide to user 
            Console.WriteLine("_Welcome to the address book program_");
            Console.WriteLine();
            Console.WriteLine("Enter the number of Address Books you want to add:");
            Console.WriteLine();

            int numAddBook = Convert.ToInt32(Console.ReadLine());          //taking user inputs about the number of add books needed
            int numberBook = 0;
            Console.WriteLine();
            while (numberBook < numAddBook)                                //this while loop runs till the favourable no. of add books are created
            {
                Console.WriteLine("Enter the name of the address book");
                string book = Console.ReadLine();                         //taking the add book name as input
                Console.WriteLine("Select the option that you would like to perform.");
                Console.WriteLine();
                //declaring address book object to be used in the below cases
                ContactBook AddObj = new ContactBook();
                string keyPress = "o";

                while (keyPress != "\n")
                {
                    Console.WriteLine("1- Add contact, 2- Display contact,3-edit contact,4-delete contact,5-Search contact, 6-SearchingByCity, 7-SearchingByState, 8-GettingCityNames, 9-GettingStateNames");
                    num = Convert.ToInt32(Console.ReadLine());

                    switch (num)               //switch case 
                    {
                        case 1:
                            ContactBook.NewPerson();
                            break;

                        case 2:
                            AddObj.Display();
                            break;
                        
                        case 3:
                            ContactBook.Delete();         //method to delete the contacts
                            break;

                        case 4:
                            ContactBook.searchPeople(list, "Shreesh");
                            break;

                        case 5:
                            ContactBook.searchbyCity();
                            break;

                        case 6:
                            ContactBook.searchbyState();
                            break;

                        case 7:
                            ContactBook.gettingCity();
                            break;

                        case 8:
                            ContactBook.gettingState();
                            break;
                    }
                    Console.WriteLine("Do you wish to continue? Press (y/n)");
                    keyPress = Console.ReadLine();
                }
                ContactBook.manyList(book);                         //calling the AddTo method to add the new address book in the dictionary
                numberBook++;                                    //incrementing the variable
            }
            Console.ReadLine();
        }
    }
}
