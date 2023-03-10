using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListClass
{
    public class LinkedListNode<L>
    {
        public L value;
        public LinkedListNode<L> prev;
        public LinkedListNode<L> next;

        public LinkedListNode(L value)
        {
            this.value = value;
            this.prev = null;
            this.next = null;
        }
    }
    public class MyLinkedList<T> : IEnumerable<T>
    {
        public LinkedListNode<T> First = null;
        public LinkedListNode<T> Last = null;

        public MyLinkedList(T[] values)
        {
            Last = First = new LinkedListNode<T>(values[0]);
            LinkedListNode<T> prev;
            for (int i = 1; i < values.Length; i++)
            {
                Last.next = new LinkedListNode<T>(values[i]);
                prev = Last;
                Last = Last.next;
                Last.prev = prev;
            }
        }
        public bool Contains(T value)
        {
            LinkedListNode<T> el = First;
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
            LinkedListNode<T> item = new LinkedListNode<T>(value);
            item.next = First;
            First.prev = item;
            First = item;
        }
        public void AddFirst(LinkedListNode<T> value)
        {
            value.prev = null;
            value.next = First;
            First.prev = value;
            First = value;
        }
        public void RemoveFirst()
        {
            First = First.next;
            First.prev = null;
        }
        public void AddLast(T value)
        {
            LinkedListNode<T> item = new LinkedListNode<T>(value);
            item.prev = Last;
            Last.next = item;
            Last = item;
        }
        public void AddLast(LinkedListNode<T> value)
        {
            value.next = null;
            value.prev = Last;
            Last.next = value;
            Last = value;
        }
        public void RemoveLast()
        {
            Last = Last.prev;
            Last.next = null;
        }
        public LinkedListNode<T> FindLast(T value)
        {
            LinkedListNode<T> node = Last;
            while (node != null)
            {
                if (node.value.Equals(value))
                {
                    return node;
                }
                node = node.prev;
            }
            return null;
        }
        public LinkedListNode<T> Find(T value)
        {
            LinkedListNode<T> node = First;
            while (node != null)
            {
                if (node.value.Equals(value))
                {
                    return node;
                }
                node = node.next;
            }
            return null;
        }
        public void AddAfter(LinkedListNode<T> current, T value)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(value);
            node.prev = current;
            node.next = current.next;
            current.next = node;
            if (node.next == null) Last = node;
            else node.next.prev = node;
        }
        public void AddBefore(LinkedListNode<T> current, T value)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(value);
            node.prev = current.prev;
            node.next = current;
            current.prev = node;
            if (node.prev == null) First = node;
            else node.prev.next = node;
        }
        public override string ToString()
        {
            string str = "";
            foreach (T value in this)
            {
                str += value + " ";
            }
            return str;
            
            //LinkedListNode<T> item = First;
            //while (item != null)
            //{
            //    str += item.value.ToString();
            //    str += " ";
            //    item = item.next;
            //}
            //return str;
        }

        public IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> node = First;
            while (node != null)
            {
                yield return node.value;
                node = node.next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            LinkedListNode<T> node = First;
            while (node != null)
            {
                yield return node.value;
                node = node.next;
            }
        }
    }
}