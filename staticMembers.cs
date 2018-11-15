using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticMembers
{
    class Program
    {


        /*Constants members are stattic by definitions*/

        /*    class Math
        {
            
           public  const int ONE = 1;

        }
        */






            /*this and read-only keyword  usage of this method is to distinguish class members from other data*/

            class Person
        {

            private string name;

            public Person(string name)
            {

                this.name = name;

            }

        }


        /*read-only read-only modifier prevents a member of a class from being modified after construction*/

            class Pers
        {
            private readonly string name = "John";

            public Pers(string name)
            {
                this.name = name;
            }

        }


        static void Main(string[] args)
        {


            /*static classes are Math class Array class String class and DateTime class*/

            Console.WriteLine("today date :" + DateTime.Now);

            Console.WriteLine("maximum date:" + DateTime.MaxValue );

            Console.WriteLine("Tofday :" + DateTime.Today);

            Console.WriteLine("DaysInMonth :" + DateTime.DaysInMonth(2016,2));


            /*Math class        Math.   */

            /*String Class  String.*/
          
            

            Console.ReadKey();
        }
    }
}
