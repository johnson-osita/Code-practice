using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace best_coding_practices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Use Camel case while declaring a variable
            var sureName = "johnson";

            //never begin a a name with numeric character
            var 0Name = 20; //wrong

            //use proper names for variables that best decribes the variable, do not use abbrevations
            var Psn = "ositadimma";

            //Never build a different name varied by capitalization else it will bw difficult to tell the difference
            var Name = "johnson";
            var name = "benedict";

            //Do not use the same name used in .NET Framework 
            var WriteLine = "jay"; //wrong format


            //Use prefixes such as “Is”, “Has” or “Can” for boolean properties, it helps give proper meaning to properties
            bool IsAuthenticated = false; //correct
            bool login = true //wrong format


            //do not use prefix or suffix of the class name to name a property
            var firstName = "jay"; //correct
            var userFirstName = "jay"; //wrong format


            //Use “I” as prefix for Interfaces
            interface IFile
            {
                void ReadFile();
                void WriteFile(string text);
            }

            //Avoid all uppercase or lowercase names for properties, variables or method names. Use all uppercase when declaring const variables

            public const int MIN_AGE = 18; //correct

            // Avoid
            public const int Min_Age = 18; //wrong format

            //For better code indentation and readability always align the curly braces vertically.

            foreach (string i in word)
            {                                   //correct
                if(string.IsUpper)
                {      
                }
            }

            foreach (string i in word)
            {                              //wrong format
                if(string.IsUpper)
                {      
                    }
                }

            //Always declare the properties as private so as to achieve Encapsulation and ensure data hiding.

            private int employeeId { get; set; } //correct
            public int employeeId { get; set; }// wrong format
}
}
