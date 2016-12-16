using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// All this program does is compare Java syntax and C# syntax.
/// </summary>
namespace Right_Traingle_Andrew
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This is Andrew's Java code...
            Scanner user = new Scanner(System.in);
            System.out.println("How many lines do you want");
            int c = input.nextInt();
            int d = c;
            int diff;
            while (c > 0)
            {
                c = c - 1;

                diff = d - c;
                for (int i = 0; i < diff; i++)
                {
                    System.out.print("*");
                }
                System.out.println("");
            }
            */

            //This is the converted C# code...
            Console.WriteLine("How many lines do you want");
            String input = Console.ReadLine();
            int c = Convert.ToUInt16(input);
            int d = c;
            int diff;
            while(c > 0)
            {
                c = c - 1;

                diff = d - c;
                for (int i = 0; i < diff; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
