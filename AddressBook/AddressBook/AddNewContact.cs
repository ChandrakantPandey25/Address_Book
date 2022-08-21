using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class AddNewContact
    {
        Dictionary<string, string> Contacts = new Dictionary<string, string>();
        Dictionary<string, Dictionary<string, string>> AddressBook = new Dictionary<string, Dictionary<string, string>>();
        public AddNewContact()
        {
            Console.WriteLine("Add the information required to enter the contact ");

            Console.WriteLine("First Name");
            Contacts.Add("First Name", Console.ReadLine());

            Console.WriteLine("Last Name");
            Contacts.Add("Last Name", Console.ReadLine());

            Console.WriteLine("Address:");
            Contacts.Add("Address", Console.ReadLine());

            Console.WriteLine("City:");
            Contacts.Add("City", Console.ReadLine());

            Console.WriteLine("State:");
            Contacts.Add("State", Console.ReadLine());

            Console.WriteLine("Zip:");
            int zip = Convert.ToInt32(Console.ReadLine());
            Contacts.Add("Zip", Convert.ToString(zip));

            Console.WriteLine("Phone number:");
            int pNumber = Convert.ToInt32(Console.ReadLine());
            Contacts.Add("Phone number", Convert.ToString(pNumber));

            Console.WriteLine("Email:");
            Contacts.Add("Email", Console.ReadLine());

            Contacts.TryGetValue("First Name", out String FirstName);
            Contacts.TryGetValue("Last Name", out String LastName);
            AddressBook.Add(FirstName + " " + LastName, Contacts);
            Console.WriteLine("contact added in the Address Book");
        }
    }
}
