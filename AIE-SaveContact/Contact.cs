using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AIE_SaveContact
{
    class Contact
    {
        public string name = "";
        public string email = "";
        public string phone = "";


        public Contact()
        {
            //aaron
            //aaron.cox @aie.edu.au
            //1234567
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
                sw.WriteLine(name);
                sw.WriteLine(email);
                sw.WriteLine(phone);
            }
        }

        public void DeSerialise(string filename)
        {
            // TODO: use StreamReader to write the name, email and phone to file
            using (StreamReader sr = File.OpenText(filename))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }

        public void Print()
        {
            Console.WriteLine($"{name} {email} {phone}");
        }
    }
}
