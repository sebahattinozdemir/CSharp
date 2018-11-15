using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {

        class Person
        {
            private string name;
            
            public string Name
            {
                get { return name; }

                set { name = value; }


            }

            public string  getName()
            {

                return name;
            }

            public Person(string nm)
            {

                name = nm;
                Console.WriteLine("Constructor called.");

            }



        }


        static void Main(string[] args)
        {

            Person ali = new Person("ali");

            Console.WriteLine(" my name is " + ali.getName());

            ali.Name = "Ahmet ";

            Console.WriteLine(" my name is " + ali.Name);

            Console.ReadKey();


        }
    }
}
