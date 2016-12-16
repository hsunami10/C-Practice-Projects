using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// The purpose of this program is to print out a right triangle using stars, and having the user enter in the number of rows.
/// </summary>
namespace Right_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter in the number of rows: ");
            String input = Console.ReadLine();
            //changes a string type into an int type
            int rows = Convert.ToUInt16(input);

            for (int i = 0; i < rows; i++)
            {
                for (int a = 0; a <= i; a++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine("");
            }
        }
    }
}
