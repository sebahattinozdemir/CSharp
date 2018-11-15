using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            /* cond operator
            Console.WriteLine("Hello Enter your age I will display Welcome or sorry message");

            int x = Convert.ToInt32(Console.ReadLine());

            string message = (x >= 18) ? "Welcome" : "Sorry";

            Console.WriteLine("you message is {0}" , message);
            Console.ReadLine();
            */

            // basic calculator

            Console.WriteLine("Choose an operation");
            Console.WriteLine("For + operation press 1");
        
            Console.WriteLine("For - operation press 2");
           
            Console.WriteLine("For / operation press 3");
          
            Console.WriteLine("For * operation press 4");
            int x = Convert.ToInt32(Console.ReadLine());
            int num1, num2,result;
            switch (x)
            {

                case 1: Console.Write("Enter the first number:");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the second number:");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    result = num1 + num2;
                    Console.WriteLine("Result of sum Operation : " + result );
                    break;

                case 2:
                    Console.Write("Enter the first number:");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the second number:");

                    num2 = Convert.ToInt32(Console.ReadLine());

                    result = num1 - num2;
                    Console.WriteLine("Result of minus Operation : " + result);

                    break;

                case 3:
                    Console.Write("Enter the first number:");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the second number:");

                    num2 = Convert.ToInt32(Console.ReadLine());

                    if (num2 == 0)
                    {
                        Console.Write("Enter the second number again ' cant divide by 0");
                        num2 = Convert.ToInt32(Console.ReadLine());

                    }

                    result = num1 / num2;

                    Console.WriteLine("Result of divide Operation : " + result);


                    break;


                case 4:
                    Console.Write("Enter the first number:");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the second number:");

                    num2 = Convert.ToInt32(Console.ReadLine());

                    result = num1 * num2;
                    Console.WriteLine("Result of multiply Operation : " + result);

                    break;

                default:

                    Console.WriteLine("Invalid Operatin");

                    break;

            }

            Console.ReadKey();




        }
    }
}
