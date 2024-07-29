using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2AdvancedC_.Classes
{
    //1.Create a generic class named FixedSizeList<T>.
    internal class FixedSizeList<T>
    {
        private T[] items;
        private int count;
        private int capacity;

        public int Count
        {
            get { return count; }
        }

        public int Capacity
        {
            get { return items.Length; }
        }

        //2.Implement a constructor that takes the fixed capacity of the list as a parameter.
        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentException("Capacity must be greater than zero.");
            }
            items = new T[capacity];
            count = 0;
        }

        //3.Implement an Add method that adds an element to the list, but throws an exception if the list is already full.
        public void Add(T item)
        {
            if (count >= items.Length)
            {
                throw new InvalidOperationException("List is full. Cannot add more elements.");
            }
            items[count] = item;
            count++;
        }

        //4.Implement a Get method that retrieves an element at a specific index in the list but throws an exception for invalid indices.
        public T Get(int index)
        {
            if ((index < 0) || (index >= count))
            {
                throw new ArgumentOutOfRangeException("Index is out of Range.");
            }
            return items[index];
        }
    }
}
