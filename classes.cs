using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Program
    {
 
        
/************************************************************************************************************************************************************************/

        class Person
        {
            // by default goes private you cant reach the variables of the age and name outsude of the class
            //Thus is called encapsulation
            int age;
            string name;

            public void sayHi()
            {

                Console.WriteLine("Hello " + name);

            }


            /*Constructors is publuc and does not have any return type automatically called when an object is created
             Very useful fir setting initial values foe certain members as default constructor has no members
                 */

            public Person()
            {

                Console.WriteLine("Constructor called ...");
            }

            public Person (string nm)
            {
                name = nm;
            }

            public string getName()
            {
                return name;
            }

            /*property is a member taht provides flexible mechanism fir private fields with properties privatte fields they caan treated as oublic members*/

            private string  Lastname; /* this is a field */

            public string LastName/*this is a property that has bth get and set accessors*/
            {
                get { return Lastname; }
                set { Lastname = value; }

            }






        }

 /************************************************************************************************************************************************************************/
        class Dog
        {
            //by public you can access the variables name and age outside of the class
            public string name;

            public int age;

        }

 /************************************************************************************************************************************************************************/


        class BankAccount
        {
            /*private acces modifier makes memebers only accesible from within the class and hides from outside */
            private double balance;

            public void Deposit (double n)
            {

                balance += n;
            }

            public void WithDraw (double n)
            {
                balance -= n;
            }

            public double GetBalance()
            {
                return balance;

            }


        }
        /************************************************************************************************************************************************************************/

        /* encapsiulation called information hiding */



        static void Main(string[] args)
        {

            Person p1 = new Person("sebahattin");
            Person p2 = new Person();
            //p1.sayHi();

            p1.LastName = "kaya";
            Console.WriteLine("myname: " + p1.getName() + "  Last name " + p1.LastName);
            

            Dog bob = new Dog();

            bob.name = "bob";
            bob.age = 4;

            Console.WriteLine("name: "+ bob.name + "  age: "+bob.age);

            Console.ReadKey();
        }
    }
}
