using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        /*As described polymorphism is used when you have different implementations in each class with same method*/
        /*Abstract keyword and specify that the derived classes must define that methods of on their own*/
        /*You can not create objects of a class containing an abstract method which is why the class itself should be abstract*/


            abstract class Shape
        {
            public abstract void Draw();
        }
        /*
         - abstract methods only allowed in abstract class
         - memebrs marked as abstract must be impleneted by classes that derive from abstract class    
         - Abstract clas is intended to be base class of other classes   
             */
        
        class Circle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Circle Draw");
            }
        }

        class Rectangle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Rect Draw");
            }
        }


        static void Main(string[] args)
        {
            Shape c = new Circle();
            Shape rec = new Rectangle();

            c.Draw();
            rec.Draw();
            

        }
    }
}
