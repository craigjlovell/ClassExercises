using System;
using System.Collections.Generic;

namespace AIE_32_SaveContactList
{

    class Contact
    {
        public string name = "";
        public string email = "";
        public string phone = "";

        public Contact()
        {

        }

        public Contact(string name, string email, string phone)
        {
            this.name = name;
            this.email = email;
            this.phone = phone;
        }

        public void Print()
        {
            Console.WriteLine($"{name} {email} {phone}");
        }
    }
}