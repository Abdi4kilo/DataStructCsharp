using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PluralSIght
{
    public class LinkedList<T> : ICollection<T>
    {
        public LinkedNode<T> Head { set; private get; }
        public LinkedNode<T> Tail { set; private get; }
        public LinkedList ( )
        {
            Head = null;
            Tail = null;
        }

        public void addFirst(T value)
        {
            addFirst(new LinkedNode<T>(value));
        }

        public void addFirst (LinkedNode<T> node)
        {
            LinkedNode<T> temp = Head;
            Head = node;
            Head.Next = temp;
            if (temp == null)
            {
                Tail = Head;
            }
        }
        public void addLast (T value)
        {
            addLast(new LinkedNode<T>(value));
        }
        public void addLast (LinkedNode<T> node)
        {
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
            }
            Tail = node;
        }
        public void removeFirst ( )
        {
            if (Head != null)
            {
                Head = Head.Next;
                if (Head == null)
                    Tail = null;
            }
        }
        public void removeLast ( )
        {
            if (Tail != null)
            {
                if (Head.Next == null)
                {
                    Tail = null;
                    Head = null;
                }
                else
                {
                    LinkedNode<T> temp = Head;
                    while (temp.Next != Tail)
                    {
                        temp = temp.Next;
                    }
                    temp.Next = null;
                    Tail = temp;

                }
            }
        }
        
        public void print ( )
        {
            LinkedNode<T> temp = Head;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
        }

        public void Add (T item)
        {
            addFirst(new LinkedNode<T>(item));
        }

        public void Clear ( )
        {
            throw new NotImplementedException();
        }

        public bool Contains (T item)
        {
            LinkedNode<T> temp = Head;
            while (temp!= null && !temp.Data.Equals(item))
            {
                temp = temp.Next;
            }
            if (temp != null)
                return true;
            return false;
        }

        public void CopyTo (T[] array, int arrayIndex)
        {
            LinkedNode<T> temp=Head;
            while (temp != null)
            {
                array[arrayIndex++] = Head.Data;
                temp = temp.Next;
            }
        }

        public int Count
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsReadOnly
        {
            get 
            {
                return false;
            }
        }

        public bool Remove (T item)
        {
            LinkedNode<T> current=Head;
            LinkedNode<T> previous=null;
            while (current != null && !item.Equals(current.Data))
            {
                previous = current;
                current=current.Next;
            }

            if (current != null)
            {
                if (previous!= null){
                    previous.Next = current.Next;
                    if (current.Next == null)
                        Tail = previous;
                }
                else
                    removeFirst();
                return true;
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator ( )
        {
            LinkedNode<T> current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator ( )
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main (string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            


            list.print();
            IEnumerator<int> enumerator = list.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            Console.ReadLine();

        }
    }
}
