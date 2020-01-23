using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHello
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
            Console.ReadLine();
            //Exercise 1 Questions 1 - 3
            int myInt = 1;

            //Questions 4 - 5
            float myFloat;
            myFloat = 0.42f;
            bool myBoolean = true;
            string myName = "John";
            char myChar = 'a';

            //Exercise 2 Questions 1 - 3
            double d = 5673.74;
            int i;
            // cast double to int (read casting in book)
            i = (int)d;
            Console.WriteLine(i);


            //Exercise 2 questions 4 - 8
            string userEnteredValue = "542.12";
            long flightCost = Convert.ToUInt32(userEnteredValue);
            Console.WriteLine(flightCost);
            Console.WriteLine(myInt);

            //Exercise 3 questions 1 - 2
            StringBuilder address = new StringBuilder();
            address.Append("8150");
            address.Append(", Marne Road");
            address.Append(", Ft Benning, GA 31905");
            string concatenatedAddress = address.ToString();
            Console.WriteLine(concatenatedAddress);

            //Exercise 3 questions 3 - 5
            Regex rx = new Regex(@"\b(?<word>\w+)\s+(\k<word>)\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            string smtText = "The Cloud Apps Developer Program is a great great opportunity to start a new career career.";
            // Find mach of duplicate of words.
            MatchCollection Matches = rx.Matches(smtText);
            // Report the number of matches found.
            Console.WriteLine("{0} matches found in:\n {1}", Matches.Count, smtText);
            
      }
    }
}
