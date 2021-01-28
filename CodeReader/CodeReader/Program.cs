using System;
using System.IO;

namespace CodeReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstLinef1, firstLinef2, secretCode="";
            StreamReader file;

            // --- Time Of Check (TOC) ----
            file = new StreamReader(@"f1.txt");
            firstLinef1 = file.ReadLine();
            file.Close();
            // ----------------------------

            // --- Code between TOC&TOU ---
            file = new StreamReader(@"f2.txt");
            firstLinef2 = file.ReadLine();
            file.Close();
            // ...
            // ----------------------------

            // --- Time Of Use (TOU) ------
            if(firstLinef1.Equals(firstLinef2))
            {
                file = new StreamReader(@"f1.txt");
                file.ReadLine();
                secretCode = file.ReadLine();
                file.Close();
            }
            // ----------------------------

            Console.WriteLine("The secret code is: " + secretCode);

            Console.ReadLine();
        }
    }
}
