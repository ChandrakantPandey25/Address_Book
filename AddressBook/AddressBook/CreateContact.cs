using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class CreateContact
    {
        
        public string First_Name;
        public string Last_Name;
        public string Address;
        public string City;
        public string State;
        public int Zip;
        public int Phone_Number;
        public string email;
       

        public CreateContact(/*string First_Name, string Last_Name, string Address, string City, string State, int Zip, int Phone_Number, string email*/)
        {
            //this.First_Name = First_Name;
            //this.Last_Name = Last_Name;
            //this.Address = Address;
            //this.City = City;
            //this.Zip = Zip;
            //this.Phone_Number = Phone_Number;
            //this.email = email;

            Console.WriteLine("Add the information required to enter the contact ");

            Console.WriteLine("First Name");
            this.First_Name = Console.ReadLine();

            Console.WriteLine("Last Name");
            this.Last_Name= Console.ReadLine();

            Console.WriteLine("Address:");
            this.Address= Console.ReadLine();

            Console.WriteLine("City:");
            this.City=Console.ReadLine();

            Console.WriteLine("State:");
            this.State =Console.ReadLine();

            Console.WriteLine("Zip:");
            this.Zip= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Phone number:");
            this.Phone_Number= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Email:");
            this.email= Console.ReadLine();

            
            
            
        }
    }
}
