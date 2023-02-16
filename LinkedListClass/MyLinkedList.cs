using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListClass
{
    public class MyLinkedList<T>
    {
        public class Item
        {
            public T value;
            public Item prev;
            public Item next;
        }

    }
}
