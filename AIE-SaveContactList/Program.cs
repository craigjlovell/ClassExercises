using System;
using System.Collections.Generic;
using System.IO;

namespace AIE_32_SaveContactList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contact> contacts = new List<Contact>();
            contacts.Add(new Contact("bob", "bob@email.com", "12345678"));
            contacts.Add(new Contact("fred", "fred@email.com", "12345678"));
            contacts.Add(new Contact("ted", "ted@email.com", "12345678")); 

            // save to file
            SerialiseContactList("contacts.txt", contacts);

            // clear them out
            contacts = new List<Contact>();

            // read from file
            DeSerialiseContactList("contacts.txt", contacts);

        }

        static void SerialiseContactList(string filename, List<Contact> contacts)
        {
            // TODO save all contacts to file.
            if (!File.Exists(filename) || File.Exists(filename))
            {
                using (StreamWriter sw = File.CreateText(filename))
                {
                    for (int i = 0; i < contacts.  Count; i++)
                    {
                        sw.WriteLine("name " + contacts[i].name);
                        sw.WriteLine("email " + contacts[i].email);
                        sw.WriteLine("phone " + contacts[i].phone);
                        sw.WriteLine("");
                    }
                }


            }
            
        }

        static void DeSerialiseContactList(string filename, List<Contact> contacts)
        {
            Contact c = new Contact();

            // TODO load all contacts from file.
            using (StreamReader sr = File.OpenText(filename))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(s))
                    {
                        contacts.Add(c);
                        c = new Contact();
                    }
                    else
                    {
                        var word = s.Split();

                        if (word[0] == "name") c.name = word[1];
                        if (word[0] == "email") c.email = word[1];
                        if (word[0] == "phone") c.phone = word[1];
                    }
                }
            }

        }
    }
}