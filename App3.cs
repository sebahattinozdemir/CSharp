using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {

        static int sqr (int x)
        {

            return x * x;

        }

        static void sayHi(string name)
        {

            Console.WriteLine("Hello " + name);

        }

        static void Print(string x)
        {
            Console.WriteLine(x);


        }

        static int sum (int x, int y)
        {

            return x + y;

        }

        static void Main(string[] args)
        {

            Console.Write("Enter your name:");

            string name = Console.ReadLine();

            sayHi(name);

            Console.WriteLine("Enter a number you will see square of the number:");
            int num = Convert.ToInt16(Console.ReadLine());


            Console.WriteLine("Square of that number :" + sqr(num));
            Print("kanka");

           
            Console.WriteLine("sum :{0}", sum(5,67));

            Console.ReadKey();

        }
    }
}
