using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        class Box
        {
            public int height;
            public int width;

            public Box(int h, int w)
            {
                height = h;
                width = w;
            }
            public Box()
            {

                
              

            }
            /*operator overloading  overloaded operator must be static*/

                /*other opeators can also be overloaded */
            public static  Box  operator+ (Box b1 , Box b2)
            {
                Box b3 = new Box(0,0);

                b3.height = b1.height + b2.height;
                   b3.width = b1.width + b2.width;

                return b3;
            }


        }


        static void Main(string[] args)
        {

            Box b1 = new Box(3,5);
            Box b2 = new Box(4, 7);

            Box b3 = new Box();

            b3.height =  b1.height + b2.height;
            b3.width  =  b1.width + b2.width;

            Console.WriteLine("b3 height : " + b3.height);
            Console.WriteLine("b3 width : " + b3.width);
            Console.ReadKey();
        }
    }
}
