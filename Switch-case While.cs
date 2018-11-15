using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {


            int x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {


                case 1:
                    Console.WriteLine("one");
                    break;

                case 2:
                    Console.WriteLine("two");

                    break;

                case 3:
                    Console.WriteLine("three");

                    break;

                default:
                    Console.WriteLine("No match");

                    break;



            }


            while (x < 100)
            {

                Console.WriteLine("I am okey");
                x++;
            }


            Console.ReadKey();

        }
    }
}
