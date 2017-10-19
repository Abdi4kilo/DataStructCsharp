using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PluralSIght
{
    public class LinkedNode<T>
    {
        public T Data{get;set;}
        public LinkedNode<T> Next { get; set; }
        public LinkedNode(T value){
            Data = value;
        }
    }
}
