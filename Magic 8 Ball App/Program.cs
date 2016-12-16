using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Magic_8_Ball_App
{
    //class Human
    //{
    //    // If static, then you don't have to create an instance
    //    // Private can only be seen in the scope of the class

    //    private static string name = "Michael";
    //    private static string last = "Hsu";
    //    private static int age = 17;
    //    public static string nickname = "hsuperman";
    //}

    /// <summary>
    /// Entry point for Magic 8 Ball program (By: Michael Hsu)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //// This is an instance
            //Human h1 = new Human();
            //// Directly call the class and its public variable, nickname
            // Human.nickname = "Hsuperman";
            
            // Preserve the current console text color
            ConsoleColor oldColor = ConsoleColor.Gray;
            
            TellPeopleWhatProgramThisIs();

            // Create a randomizer object
            Random randomObject = new Random();

            // Loop forever
            while (true)
            {
                string questionString = GetQuestionFromUser();

                // See if the user typed 'quit' as a question
                if (questionString.ToLower() == "quit")
                {
                    break;
                }

                // Pauses the app for 1-5 seconds, only counts milliseconds
                int numberOfSecondsToSleep = randomObject.Next(5) + 1;
                Console.WriteLine("Thinking, stand by...");
                Thread.Sleep(numberOfSecondsToSleep * 1000);

                if (questionString.Length == 0)
                {
                    Console.WriteLine("You need to type a question!");

                    // Continue runs through the whole loop without executing the code after
                    // and restarts it at the beginning of the loop
                    continue;
                }

                // Get a random number
                int randNumber = randomObject.Next(4);
                int randColor = randomObject.Next(15);

                // Pass(cast) a random number into ConsoleColor --> all numbers are assigned to a color
                Console.ForegroundColor = (ConsoleColor)randColor;

                // Use random number to determine response
                switch (randNumber)
                {
                    case 0:
                        {
                            Console.WriteLine("YES!");
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("NO!");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("OF COURSE!");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("NO WAY!");
                            break;
                        }
                }
            }

            //cleaning up
            Console.ForegroundColor = oldColor;
            Console.WriteLine("Thank you for playing!");
        }

        /// <summary>
        /// This will print the name of the program and who created it to the console
        /// </summary>
        static void TellPeopleWhatProgramThisIs()
        {
            // Change the color of the console text
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Magic 8 Ball (by: Michael Hsu)\n" + "Type \"quit\" to exit");
        }

        /// <summary>
        /// This functino will return the text the user types
        /// </summary>
        /// <returns></returns>
        static string GetQuestionFromUser()
        {
            // This block will ask the user for a question
            // and store in the questionString variable
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Ask a question: ");
            Console.ForegroundColor = ConsoleColor.Red;
            string questionString = Console.ReadLine();

            return questionString;
        }
    }
}
