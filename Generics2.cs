using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gneerics
{
    class Program
    {
        private static readonly int temp;

        static void Swap <T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {


            int a = 4;
            int b = 9;

            Console.WriteLine("Before");
            Console.WriteLine("a: {0}", a);
            Console.WriteLine("b: {0}", b);

            Swap<int>(ref a, ref b);

            Console.WriteLine("after:");
            Console.WriteLine("a: {0}", a);
            Console.WriteLine("b: {0}", b);

            Console.ReadKey();
        }
    }
}
