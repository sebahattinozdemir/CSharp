using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {

        class Person
        {

            protected int Age { get; set;  }

            protected string Name { get; set; }
        }


        class Student : Person
        {
            public Student(string nm)
            {
                Name = nm;

            }

            public void Speak()
            {

                Console.WriteLine("Hello ' My name is  " + Name);
            }

        }

        static void Main(string[] args)
        {

            Student s = new Student("Sebahattin");
            s.Speak();
            Console.ReadKey();
        }
    }
}
