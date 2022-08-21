using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class EditContact
    {

        Dictionary<string, string> Contacts = new Dictionary<string, string>();
        Dictionary<string, Dictionary<string, string>> AddressBook = new Dictionary<string, Dictionary<string, string>>();
        public EditContact()
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
        
        
            Console.WriteLine("Enter full contact name");
            String ContactName = Console.ReadLine();

            if (AddressBook.ContainsKey(ContactName))
            {
                Console.WriteLine("enter choice");
                Console.WriteLine("enter 1 to edit First Name ");
                Console.WriteLine("enter 2 to edit Last Name ");
                Console.WriteLine("enter 3 to edit Address ");
                Console.WriteLine("enter 4 to edit City ");
                Console.WriteLine("enter 5 to edit State ");
                Console.WriteLine("enter 6 to edit Zip ");
                Console.WriteLine("enter 7 to edit Phone Number ");
                Console.WriteLine("enter 8 to edit email ");
                Console.WriteLine("enter 6 to edit Zip ");

                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the information ");
                String information = Console.ReadLine();

                switch (option)
                {
                    case 1:
                        AddressBook[ContactName]["First Name"] = information;
                        break;
                    case 2:
                        AddressBook[ContactName]["Last Name"] = information;
                        break;
                    case 3:
                        AddressBook[ContactName]["Address"] = information;
                        break;
                    case 4:
                        AddressBook[ContactName]["City"] = information;
                        break;
                    case 5:
                        AddressBook[ContactName]["State"] = information;
                        break;
                    case 6:
                        AddressBook[ContactName]["Zip"] = information;
                        break;
                    case 7:
                        AddressBook[ContactName]["Phone number"] = information;
                        break;
                    case 8:
                        AddressBook[ContactName]["Email"] = information;
                        break;
                }
                Console.WriteLine("Contact edited");

            }
            else
                Console.WriteLine("contact doesn't exist");
        }
    }
}
