using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoubleLinked
{
    public class LinkedNode<T>
    {
        public T Data { get; set; }
        public LinkedNode<T> Previous{get;set;}
        public LinkedNode<T> Next {get;set;}
    }
}
