using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// The program demonstrates the declarations and uses of different data types.
/// </summary>
namespace TestData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Gray;

            // Declare variables here.
            int age;
            double grade_math, grade_science, grade_reading;
            string lastName, firstName;
            char grade;
            
            // Give values to the variables
            age = 17;
            grade_math = 94.6;
            grade_science = 93.0;
            grade_reading = 93.5;
            lastName = "Hsu";
            firstName = "Michael";
            grade = 'A';

            // Print it out on the screen
            Console.WriteLine("My name is {0} {1}", firstName, lastName);
            Console.WriteLine("I am {0} years old.", age);
            Console.WriteLine("My grade in math is {0}, my grade in science is {1},\n and my grade in reading is {2}.",
                grade_math, grade_science, grade_reading);
            Console.WriteLine("I have an average of a(n) {0} in all of my classes.", grade);
        }
    }
}
