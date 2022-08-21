﻿using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program!!");
            Console.WriteLine("Enter 1 to Create contact");
            Console.WriteLine("Enter 2 to Add new contact");
            Console.WriteLine("Enter 3 to edit contact");
            Console.WriteLine("Enter 4 to delete contact");

            switch(Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    CreateContact contact = new CreateContact(/*First_Name,Last_Name,Address, City, State,  Zip, Phone_Number, email*/);
                    Console.WriteLine("Contact created");
                    break;
                case 2:
                    AddNewContact newContact = new AddNewContact();
                    break;
                case 3:
                   
                    EditContact edit = new EditContact();
                    break;
                case 4:

                    DeleteContact delete = new DeleteContact();
                    break;
                default:
                    Console.WriteLine("Enter valid number!!");
                    break;
            }

        }
    }
}
