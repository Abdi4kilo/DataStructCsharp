using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackLinked
{
    class Program
    {
        static void Main (string[] args)
        {
            Stack<int> newStack = new Stack<int>();
            newStack.push(1);
            newStack.push(2);
            newStack.push(3);
            newStack.push(4);
            IEnumerator<int> enumerate = newStack.GetEnumerator();
            while (enumerate.MoveNext())
            {
                Console.WriteLine(enumerate.Current);
            }
            Console.WriteLine(newStack.pop());
            Console.WriteLine(newStack.pop());
            Console.WriteLine(newStack.pop());
            Console.ReadLine();
        }
    }
}
