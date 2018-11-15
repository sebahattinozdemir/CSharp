using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceANDPolymorphism
{
    class Program
    {





        /*
         
             
             public members can  accesed outside of the clases 
             
            private members is only accesible from inside of the class

            protected members is accesible from class and derived class

            encapsulation is information hiding We can do this via access modifiers
             
               
             */




        class Animal
        {
            public int Name { get; set; }
            public int Legs { get; set; }
            public int Age { get; set; }


        }
        

        class Dog : Animal
        {

            public Dog()
            {

                Legs = 4;
                
            }

            public void Barking()
            {
                Console.WriteLine("Woof woof");
            }





        }










        static void Main(string[] args)
        {

            Dog d = new Dog();

            Console.WriteLine("dog have   " + d.Legs + " legs. ");
            d.Barking();


            Console.ReadKey();


        }
    }
}
