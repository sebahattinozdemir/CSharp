using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Program
    {

        /*you typically use an indexer if the class represents a list  collection or array of objects*/

            class Clients
        {
            private string[] names = new String[10];
            public string this [int index]
            {
                get
                {
                    return names[index];
                }
                set { names[index] = value; }
            }

        }



        static void Main(string[] args)
        {
            Clients c = new Clients();

            c[0] = "Dave";
            c[1] = "Bob";

            Console.WriteLine(c[0]);
            Console.ReadKey();
        }
    }
}
