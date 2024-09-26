using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class FixedListSize<T>
    {
        private T[] list;
        public int size { get; }
        public int Count { get; }

        public FixedListSize(int size)
        {
            this.size = size;
            list = new T[size];
            Count = 0;
        }

        public void Add(T item)
        {
            if(Count == size) 
                throw new Exception("List is full");

            list[Count] = item;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= Count)
                throw new Exception("Index out of range");

            return list[index];
        }

    }
}
