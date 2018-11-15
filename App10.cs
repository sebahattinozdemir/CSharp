using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "sebahattin";
            string lastName = "ozdemir";

            // some useful functions for strings


            Console.WriteLine("length :" + name.Length);

            Console.WriteLine("insert (t):" + name.Insert(0,"manipule"));

            Console.WriteLine("replace :  " +   name.Replace("manipule ", "for "));

            Console.WriteLine("contais(seb) :" + name.Contains("seb"));

         
            Console.WriteLine("name remove function :" + name.Remove(0,4));

            Console.WriteLine("substring :" + name.Substring(7));


            Console.ReadKey();









        }
    }
}
