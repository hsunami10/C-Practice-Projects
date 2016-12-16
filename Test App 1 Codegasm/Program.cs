using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// This is my very first C# program. All it does is use functions, for loops, and if statement to output data onto the console
/// </summary>

//namespace
namespace Test_App_1_Codegasm
{
    //Class contains functionality
    //whatever's in the brackets is in the "scope" of the class
    class Program
    {

        /// <summary>
        /// Entry point
        /// </summary>
        /// <param name="args"></param>
        //function (entry point)
        static void Main(string[] args)
        {
            String s = "Hello World!";
            int i = 10;

            PrintFooToScreen();

            //starting point of everything
            Console.WriteLine("Hello. How are you today?");
            Console.WriteLine(s);

            //have the console print something out, then have the user answer
            Console.WriteLine("Type a number, any number.");
            ConsoleKeyInfo keyinfo = Console.ReadKey();

            if (keyinfo.KeyChar == 'a')
            {
                Console.WriteLine("That is not a number.");
            }
            else
            {
                Console.WriteLine("Did you type: {0}", keyinfo.KeyChar.ToString());
            }
            //call PrintFooToScreen
            PrintFooToScreen100x();
        }

        static void PrintFooToScreen()
        {
            Console.WriteLine("Foo");
        }

        //this function prints Foo to screen 100x
        static void PrintFooToScreen100x()
        {
            for(int counter = 0; counter < 100; counter++)
            {
                PrintFooToScreen();
            }
        }
    }
}
