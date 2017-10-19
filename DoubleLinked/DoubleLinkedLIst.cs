using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoubleLinked
{
    public class DoubleLinkedLIst<T>:ICollection<T>
    {
        public LinkedNode<T> Head { get; private set; }
        public LinkedNode<T> Tail { get; private set; }
        private int count=0;
        public void addFirst (T data)
        {
            addFirst(new LinkedNode<T> { Data = data });
        }
        public void addFirst (LinkedNode<T> node)
        {
            if (Head == null)
            {
                Tail = node;
            }
            else
            {
                Head.Previous = node;
                node.Next = Head;
            }
            Head = node;

            
            
           
            count++;
            
        }
        public bool Remove(T item)
        {
            LinkedNode<T> current = Head;
            while (current != null && !current.Data.Equals(item))
            {
                current = current.Next;
            }
            if (current == null)return false;

            if (Object.ReferenceEquals(current, Head))
            {
                Head = current.Next;
                Head.Previous = null;
                return true;
            }
            if (Object.ReferenceEquals(current, Tail))
            {
                Tail = Tail.Previous;
                Tail.Next = null;
                return true;
            }
            current.Next.Previous = current.Previous;
            current.Previous.Next = current.Next;
            
            return true;
        }
        public void addLast (LinkedNode<T> node)
        {
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                node.Previous = Tail;
                Tail.Next = node;
            }
            Tail = node;
            count++;
        }

        public void addLast (T item)
        {
            addLast(new LinkedNode<T> { Data = item });
        }
        public void Add (T item)
        {
            addFirst(item);
        }

        public void Clear ( )
        {
            throw new NotImplementedException();
        }

        public bool Contains (T item)
        {
            LinkedNode<T> current = Head;
            while (current != null)
            {
                if (current.Data.Equals(item))
                    return true;
                current=current.Next;
            }
            return false;    
        }

        public void CopyTo (T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { return count; }
        }

        public bool IsReadOnly
        {
            get {
                return false;
            }
        }

       

        public IEnumerator<T> GetEnumerator ( )
        {
            LinkedNode<T> current=Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator ( )
        {
            throw new NotImplementedException();
        }
    }
}
