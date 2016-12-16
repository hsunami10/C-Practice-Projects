using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//this program calculates the area and circumference of a circle

namespace Variable
{
    class Program
    {
        /// <summary>
        /// print out the radius, value of PI, area, diameter
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int radius = 5;
            const double PI = 3.141592653;

            System.Console.WriteLine("The radius of the circle is: {0}", radius);
            System.Console.WriteLine("The value of PI is: {0}", PI);

            double area = PI * radius * radius;
            double circumference = PI * 2 * radius;

            System.Console.WriteLine("The area of the circle is: {0}", area);
            System.Console.WriteLine("The circumference of the circle is: {0}", circumference);
        }
    }
}
