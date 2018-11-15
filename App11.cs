using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {

        class Dog{

            string name;

            string age;

            public string Age { get; set; }
            public string Name { get; set; }


            /*Constructors*/

           public Dog()
            {
            Console.WriteLine("Constructor called...");


            }
            /* Destructor is used for relaesing resources before destroyed or deleted It doesn ot take paramaeters and it is privtee It cann not be called.*/
            ~Dog()
            {
                Console.WriteLine("Destructor  called.");

            }





        }

        static void Main(string[] args)
        {
            Dog d = new Dog();
            Console.ReadKey();
        }
    }
}
