using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphism
{
    class Program
    {

        /* Polymorhphism means having many forms 
           actually it means a single method and have a number of diffrent implementations
         */


        class Shape
        {
            /*virtual keyword allows methods to  be overridden in derived class*/
            public virtual void Draw()
            {
                Console.WriteLine("Base Draw");
            }

        }
        class Circle : Shape
        {
            /*with override method youn implicitly declare the method*/
            public override void Draw()
            {
                Console.WriteLine("Circle Draw");
            }

        }

        class Rectangle : Circle
        {
            public override void Draw()
            {
                Console.WriteLine("Rectangle Draw");
            }

        }




        static void Main(string[] args)
        {
            Shape s = new Shape();
            Circle c = new Circle();
            Rectangle rec = new Rectangle();

            s.Draw();
            c.Draw();
            rec.Draw();
            Console.ReadKey();
        }
    }
}
