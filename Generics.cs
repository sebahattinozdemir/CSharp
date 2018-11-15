using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{
    class Program
    {



        class Stack<T>
        {
            int index = 0;
            T[] innerArray = new T[100];

            public void Push (T item)
            {

                innerArray[index++] = item;

            }

            public T Pop()
            {

                return innerArray[--index];
            }

            public T Get(int k)
            {
                return innerArray[k];
                
            } 

        }


        static void Main(string[] args)
        {
            Stack <int>  Stack = new Stack<int>() ;
            Stack.Push(15);
            Stack.Push(12);
            Stack.Push(17);

            Console.WriteLine(Stack.Pop());
           

            List<int> numbers = new List<int>();
            numbers.Add(13);
            numbers.Add(12);
            Console.WriteLine(numbers.Count());

            Queue <int> q = new Queue<int>();
            q.Enqueue(15);
            q.Enqueue(14);
            q.Enqueue(13);
            Console.WriteLine(q.Average());


            Console.ReadKey();

        }
    }
}
