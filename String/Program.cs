using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    /// <summary>
    /// Demonstrates the manipulation of strings 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Sets the text color back to its original
            Console.ForegroundColor = ConsoleColor.Gray;

            // 2 String variables
            string s1 = "My name is";
            string s2 = "Jane";

            // Prints out these variables
            Console.WriteLine("{0} {1}", s1, s2);

            // Prints out the size of string number 1
            Console.WriteLine("The size of string s1 is {0} characters long", s1.Length);

            // Substring examples
            // First number is the starting point
            // Second number is the number of chars after the first, not counting the last
            Console.WriteLine("This is Substring(3,4): {0}", s1.Substring(3, 4));

            string s3 = "Allan Alda";
            string s4 = "John Wayne";
            string s5 = "Gregory Peck";

            Console.WriteLine("{0}", s3.Substring(2, 5));
            Console.WriteLine("{0}", s4.Substring(2, 5));
            Console.WriteLine("{0}", s5.Substring(2, 7));


        }
    }
}
