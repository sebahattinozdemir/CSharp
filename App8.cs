using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {


        /*Auto-implemented Property*/

            /* Why use propertis ?  Because you can control the logic of the accesing variable*/
        class Person
        {
       /*you dont need to declare the private field name separetely, it is created by the property automatically*/   
            public string  Name { get; set; } // auto-implemented property


        }


        static void Main(string[] args)
        {

            Person p = new Person();

            p.Name = "Ali";

            Console.WriteLine("my name is " + p.Name);
            Console.ReadKey();

        }
    }
}
