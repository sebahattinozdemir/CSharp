using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedClass
{
    class Program
    {
        class Car
        {
            string name;

            public Car (string nm)
            {
                name = nm;
                Motor m = new Motor();
            }

        }
        /*the motor class is nested in the car class and can be used to similar to other members of the class just like in real life objects can contain other objects*/
        public class Motor
        {
            string Mname;

        }

        static void Main(string[] args)
        {
        }
    }
}
