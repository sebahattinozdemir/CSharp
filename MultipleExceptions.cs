using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleExceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            /*A single try blocj can contain multiple catch blocks*/
            /* Most used exceptions are :
             
             1- FileNotFoundException
             2- FormatException
             3- IndexOutOfRangeException
             4- OutOfMemeoryException
             5- InvalidExceptionOperation
                        
             */

            /*finally keyword
             it is optional ater catch blocks finall blocks is used to execute a given set of statements
             Can be used when working with files or other resources these should be closed or releasedin final block
             */

            try
            {
                int x  = Convert.ToInt32(Console.ReadLine());
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(x / y);
            }

            catch(DivideByZeroException e)
            {
                Console.WriteLine("Can not divide by zero");

            }

            catch (Exception e)
            {
                Console.WriteLine("An error occured");

            }

            finally
            {

                Console.WriteLine("normal completion");
            }

            Console.ReadKey();
        }
    }
}
