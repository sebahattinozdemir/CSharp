using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {


        static int Pow(int x, int y = 2)
        {
            int res=1;
            int i = 0;
            for (i = 0; i < y; i++)
            {

                res *= x;
            }

            return res;
        }
        static void Main(string[] args)
        {


            // optional argumnets


            Console.WriteLine("Square  of two : " + Pow(2));

            //Another thing 

            Console.WriteLine("Hello enter two int:");

            int x = Convert.ToInt16(Console.ReadLine());
            int y = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(x+ "^"+y+ "=" + Pow(x,y));

            Console.ReadKey();
        }
    }
}
