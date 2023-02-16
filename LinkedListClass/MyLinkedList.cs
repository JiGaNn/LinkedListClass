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

            public Item(T value)
            {
                this.value = value;
                this.prev = null;
                this.next = null;
            }
        }
        private Item head = null;
        private Item tail = null;

        public T First;

        public MyLinkedList(T[] values)
        {
            tail = head = new Item(values[0]);
            First = values[0];
            Item prev;
            for(int i = 1; i < values.Length; i++)
            {
                tail.next = new Item(values[i]);
                prev = tail;
                tail = tail.next;
                tail.prev = prev;
            }
        }
        public bool Contains(T value)
        {
            Item el = head;
            while (el != null)
            {
                if (el.value.Equals(value))
                {
                    return true;
                }
                el = el.next;
            }
            return false;
        }
        public void AddFirst(T value)
        {
            Item item = new Item(value);
            item.next = head;
            head.prev = item;
            head = item;
            First = value;
        }
        public override string ToString()
        {
            string str = "";
            Item item = head;
            while (item != null)
            {
                str += item.value.ToString();
                str += " ";
                item = item.next;
            }
            return str;
        }

    }
}
