using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AIE_SaveContactV2
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

        public void Serialise(string filename)
        {

             if (!Directory.Exists("./contacts"))
            {
                DirectoryInfo di = Directory.CreateDirectory("./contacts");
            }

            // TODO: use StreamWriter to write the name, email and phone to file
            using (StreamWriter sw = File.CreateText(filename))
            {
                if (!string.IsNullOrWhiteSpace(name)) sw.WriteLine("name: " + name);
                if (!string.IsNullOrWhiteSpace(email)) sw.WriteLine("email: " + email);
                if (!string.IsNullOrWhiteSpace(phone)) sw.WriteLine("phone: " + phone);
            }
        }

        public void DeSerialise(string filename)
        {
            // TODO: use StreamReader to write the name, email and phone to file
            using (StreamReader sr = File.OpenText(filename))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {

                    string[] parts = line.Split(" ");
                    string key = parts[0];
                    string value = parts[1];
                    if (key == "name:") name = value;
                    if (key == "email:") email = value;
                    if (key == "phone:") phone = value;

                }
            }
        }

        public void Print()
        {
            Console.WriteLine($"{name} {email} {phone}");
        }
    }
}
