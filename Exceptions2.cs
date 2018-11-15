using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

            }
            /*use e.message to display original error message*/
            catch(Exception e)
            {
                Console.WriteLine(e.Message);

            }


        }
    }
}
