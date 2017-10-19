using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoubleLinked
{
    class Program
    {
        static void Main (string[] args)
        {
            DoubleLinkedLIst<int> linked = new DoubleLinkedLIst<int>();
            //linked.addLast(1);
            //linked.addLast(2);
            //linked.addLast(3);
            //linked.addLast(4);
            //linked.addLast(5);
            //linked.addLast(6);
            //linked.Remove(4);
            linked.addFirst(5);
            linked.addFirst(4);
            linked.addFirst(3);
            linked.addFirst(2);
            linked.addFirst(1);
            linked.Remove(4);
            linked.Remove(1);
            linked.Remove(5);
            IEnumerator<int> enu = linked.GetEnumerator();
            while (enu.MoveNext())
            {
                Console.WriteLine(enu.Current);
            }
            Console.ReadLine();
        }
    }
}
