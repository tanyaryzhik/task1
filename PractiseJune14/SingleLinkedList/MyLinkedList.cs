using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseJune14.SingleLinkedList
{
    public class MyLinkedList<T>
    {
        private Node<T> First { get; set; }

        private Node<T> Last { get; set; }

        private int count;

        public MyLinkedList()
        {
            this.First = new Node<T>(default(T));
            this.Last = new Node<T>(default(T));
        }

        public void Add(T value)
        {
            if (value.Equals(default(T)))
                throw new ArgumentNullException();
            Node<T> newNode = new Node<T>(value);
            if (this.First.Value.Equals(default(T)))
            {
                this.First = newNode;
            }
            else
            {
                this.Last.Next = newNode;
            }
            this.Last = newNode;
            count++;
        }

        public void Remove(T value)
        {
            int i = 0;
            Node<T> newNode = this.First;
            Node<T> prevNode = new Node<T>(default(T));
            while(i<this.count)
            {
                if (newNode.Value.Equals(value))
                {
                    prevNode.Next = newNode.Next;
                    newNode.Invalidate();
                    count--;
                    break;
                }
                prevNode = newNode;
                newNode = newNode.Next;
                i++;
            }
        }
    }
}
