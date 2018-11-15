using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensional_Arrays
{
    class Program
    {

        static void Main(string[] args)
        {

            int [,] arr = new int [,]{ {2,3} , { 5,6}, { 4,6} };

           for(int i = 0; i < 3 ; i++)
            {

                for (int j = 0; j < 2; j++)
                    Console.WriteLine("arr"+i+j+ "  " + arr[i,j]);
            }


            Console.WriteLine("array rank: " + arr.Rank);
            Console.WriteLine("array length: "+ arr.Length);

            int[] arr1 = { 2, 4, 7 };

            Console.WriteLine(arr1.Max());
            Console.WriteLine(arr1.Min());
            Console.WriteLine(arr1.Sum());
            Console.WriteLine(arr1.Average());

         






            Console.ReadKey();


        }
    }
}
