using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class DeleteContact
    {
        Dictionary<string, string> Contacts = new Dictionary<string, string>();
        Dictionary<string, Dictionary<string, string>> AddressBook = new Dictionary<string, Dictionary<string, string>>();
        public DeleteContact()
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
            Contacts.Add("Zip", Console.ReadLine());

            Console.WriteLine("Phone number:");
            Contacts.Add("Phone number", Console.ReadLine());

            Console.WriteLine("Email:");
            Contacts.Add("Email", Console.ReadLine());

            Contacts.TryGetValue("First Name", out String FirstName);
            Contacts.TryGetValue("Last Name", out String LastName);
            AddressBook.Add(FirstName + " " + LastName, Contacts);
            Console.WriteLine("contact added in the Address Book");



            Console.WriteLine("Enter contact name to be deleted:");
            String ContactName = Console.ReadLine();
            if (AddressBook.ContainsKey(ContactName))
            {
                AddressBook.Remove(ContactName);
                Console.WriteLine("entered contact is removed");
            }
            else
                Console.WriteLine("contact doesn't exist");

        }
    }
}
