using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /*This is 
             * multiline comment*/
            //this is singleline comment

            
            Console.Write("Plesae enter your age:");
            string name=Console.ReadLine();

            Console.WriteLine("Hello " + name);

            Console.WriteLine("Your Age please:");

            int age = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(name + " your age is " + age);

            Console.ReadKey();

            /*CONST VALUE MUST BE INITILIZAED WHEN DECLARED*/
            const double PI = 3.14;

            
            /*PI = 5; CANT CHANGE ITS VALUE AFTER INITILIAZTION*/


             
            
                




        }
    }
}
