using System;
using System.IO;

namespace AIE_WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @".\MyTest.txt";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Hello");
                    sw.WriteLine("Welcome To AIE");
                    sw.WriteLine("Year 1 Game Programmers");
                }
            }

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
