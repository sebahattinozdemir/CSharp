using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        /*An exception is a problem that ocuurs during program executin*/
        /* eXception are caused by user error programmer error or physical error a good programm should handle all posssible errors*/

        static void Main(string[] args)
        {
            try
            {
                int[] arr = new int[] { 4, 5, 8 };

                Console.WriteLine(arr[8]);
            }
            catch(Exception e) {

                Console.WriteLine("An error occured");
            }

            Console.ReadKey();
        }
    }
}
