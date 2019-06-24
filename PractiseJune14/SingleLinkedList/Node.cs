using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseJune14.SingleLinkedList
{
    public class Node<T>
    {
        public T Value { get; set; }

        public Node<T> Next { get; set; }
        
        public Node(T value)
        {
            if (value == null)
                throw new ArgumentNullException();

            this.Value = value;
        }

        internal void Invalidate()
        {
            this.Value = default(T);
            this.Next = null;
        }
    }
}
