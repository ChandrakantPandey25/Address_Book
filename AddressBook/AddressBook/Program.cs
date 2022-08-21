using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program!!");
            Console.WriteLine("Enter 1 to Create contact");

            switch(Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    CreateContact contact = new CreateContact(/*First_Name,Last_Name,Address, City, State,  Zip, Phone_Number, email*/);
                    Console.WriteLine("Contact created");
                    break;
                default:
                    Console.WriteLine("Enter valid number!!");
                    break;
            }

        }
    }
}
