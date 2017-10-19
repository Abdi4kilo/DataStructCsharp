using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackLinked
{
    public class Stack<T>:IEnumerable<T>
    {
        private LinkedList<T> _list=new LinkedList<T>();
        public void push (T item)
        {
            _list.AddFirst(item);
        }
        public T pop ( )
        {
            if (_list.Count != 0)
            {
                T poped = _list.First.Value;
                _list.RemoveFirst();
                return poped;
            }
            throw new InvalidOperationException("Empty stack");
        }
        public T peek(){
            if (_list.Count != 0)
            {
                return _list.First.Value;
            }
            throw new InvalidOperationException("Empty stack");
        }
        public int Count ( )
        {
            return _list.Count;
        }
        public void clear ( )
        {
            _list.Clear();
        }
        public IEnumerator<T> GetEnumerator ( )
        {
            return _list.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator ( )
        {
            return _list.GetEnumerator();
        }
    }
}
