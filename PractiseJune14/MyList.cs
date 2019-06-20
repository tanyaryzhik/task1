using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseJune14
{
    public class MyList<T> : IMyList<T>
    {
        public T[] Array { get; set; }

        public T this[int index]
        {
            get
            {
                if (index > this.Array.Length - 1)
                    throw new IndexOutOfRangeException();
                return this.Array[index];
            }
        }

        public int Count
        {
            get
            {
                return this.Array.Length;
            }
        }

        public MyList()
        {
            this.Array = new T[0];
        }

        public void Add(T item)
        {
            T[] newArray = new T[this.Array.Length + 1];
            this.Array.CopyTo(newArray, 0);
            newArray[this.Array.Length] = item;
            this.Array = newArray;
        }

        public void Clear()
        {
            T[] newArray = new T[this.Array.Length];
            this.Array = newArray;
        }

        public bool Contains(T item)
        {
            bool contains = false;
            for (int i = 0; i < this.Array.Length; i++)
            {
                if (this.Array[i].Equals(item))
                    contains = true;
            }
            return contains;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < this.Array.Length; i++)
            {
                result.Append(this.Array[i] + ", ");
            }
            return $"Length of list is {this.Array.Length}. List contains {result}";
        }
    }
}
