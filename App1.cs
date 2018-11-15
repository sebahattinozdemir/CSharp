using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*if else */

            Console.WriteLine("Enter two integers:");

            Console.WriteLine("Enter the first string:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second string");

            int y = Convert.ToInt32(Console.ReadLine());

            if (x > y)
            {
                Console.WriteLine(x + " is greater than " + y);

            }

            else
            {
                Console.WriteLine(x + " is less than " + y);

            }

            Console.ReadKey();
           

        }
    }
}
