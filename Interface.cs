using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        /*Interface simply describes us what a class should do*/
        /*When a class implements an interface it must also implement or define , all of its methods
         
         -A class can inherit from just base class but it can implement multiple interfaces    
             
             */

        
        public interface Ishape
        {
            void Draw(); 
        }

        class Circle : Ishape
        {
            public void Draw() { Console.WriteLine("Circle Draw"); }   /*note that override keyword is not needed*/
        }


        static void Main(string[] args)
        {

            Circle c = new Circle();

            c.Draw();


        }
    }
}
