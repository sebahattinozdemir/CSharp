using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoading
{
    class Program
    {

/***************************************************************************************************************************************************************************************************************************************************/

        //Multiple methods that share same name has different parameters types and/or different number of parameters


        //overloading Print function
        static void Print (int x)
        {
            Console.WriteLine("Value "+ x);
        }


         static void Print(string x)
        {
            Console.WriteLine("Value " + x);
        }

        static void Print(float x)
        {
            Console.WriteLine("Value " + x);
        }
        
        
 /***************************************************************************************************************************************************************************************************************************************************/       
        // recursion for factorial method
         static int fact(int num)
        {
            if (num == 1)
                return 1;

            return  num * fact(num-1);
        }


        static void Main(string[] args)
        {

            Print(12);
            Print("ALI");
            Print(12.4555f);

            Console.WriteLine("Enter a number:");

            int x =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Factorial = " + fact(x));


            Console.ReadKey();
        }


    }


}
