using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachLoop
{
    class Program
    {

        /*Working with arrays*/

        static void Main(string[] args)
        {

            Console.Write("Enter size of the array:");
            int num = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[num];

            Console.Write("Enter elements  of the array:");

            for (int i = 0; i<num; i++)
            {

                a[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("Writing elements of array.");
            for(int i= 0; i< num;  i++)
            {


                Console.WriteLine(a[i]);

            }

            Console.WriteLine("sorting the array");

            Array.Sort(a);

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(a[i]);

            }

            Console.WriteLine("Sorting in reverse order");

            Array.Reverse(a);


            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(a[i]);

            }


            Console.WriteLine("Enter number you wanna find:");
            int num1 = Convert.ToInt32(Console.ReadLine());


            int findElement = Array.BinarySearch(a, num1);

           
            Console.WriteLine("element is " + findElement);

            Console.ReadKey();

        }
    }
}
