using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {


        static void Main(string[] args)
        {

            int[] myArray = new int[5];

            myArray[0] = 23;

            string[] names = new string[3] { "John", "merry", " jane" };

            double[] prices = new double[] {4.2, 4.8, 3.1, 2.9};

            Console.WriteLine("Writing names array...");
            for(int i = 0; i < 3; i++)
            {

                Console.WriteLine(names[i]);
            }

            Console.WriteLine("Writing names array...");


            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(prices[i]);

            }

            Console.ReadKey();




        }
    }
}
