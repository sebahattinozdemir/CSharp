using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed
{
    /* Sealed class can prevent other classes from inheriting it or any of its members by using sealed modifier */

  

    /* //Dog cannot derived from sealed type animal
    class Dog : animal
    {


    }*/

    /*Constuctors are called when objects of a class are created within inheritance the base class constructor and destructor are not inherited.*/



        class Animal
    {
        public Animal()
        {

            Console.WriteLine("Animal created");
        }

        ~Animal()
        {

            Console.WriteLine("Animal Deleted");


        }

       

    }

    class Dog : Animal
    {

        public Dog()
        {

            Console.WriteLine("Dog created");
        }

        ~Dog()
        {

            Console.WriteLine("Dog Deleted");


        }



    }



    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();

        }
    }
}
