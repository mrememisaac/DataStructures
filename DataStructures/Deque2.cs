using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Deque2<T>
    {
        T[] _items = new T[0];

        //the number of items in the queue
        int _size = 0;

        //The index of the first (oldest) item in the queue
        int _head = 0;

        // The index of the last (newest) item in the queue.
        int _tail = -1;

        private void GrowArray(int startingIndex)
        {
            int newLength = (_size == 0) ? 4 : _size * 2; //calculate the new size

            T[] newArray = new T[newLength]; //create the new array

            if (_size > 0)
            {
                //copy the contents of the old array to the new array
                int targetIndex = startingIndex;

                // Copy the contents... 
                // If the array has no wrapping, just copy the valid range. 
                // Else, copy from head to end of the array and then from 0 to the tail. 
                // If tail is less than head, we've wrapped. 
                if (_tail < _head)
                {
                    // Copy the _items[head].._items[end] -> newArray[0]..newArray[N]. 
                    for (int index = _head; index < _items.Length; index++)
                    {
                        newArray[targetIndex] = _items[index];
                        targetIndex++;
                    }

                    // Copy _items[0].._items[tail] -> newArray[N+1].. 
                    for (int index = 0; index <= _tail; index++)
                    {
                        newArray[targetIndex] = _items[index];
                        targetIndex++;
                    }
                }
                else
                {
                    // Copy the _items[head].._items[tail] -> newArray[0]..newArray[N] 
                    for (int index = _head; index <= _tail; index++)
                    {
                        newArray[targetIndex] = _items[index];
                        targetIndex++;
                    }
                }
                _head = startingIndex;
                _tail = targetIndex - 1; // Compensate for the extra bump.
            }
            else
            {
                // Nothing in the array. 
                _head = 0; _tail = -1;
            }
            _items = newArray;
        }

        public void EnqueueFirst(T item)
        {
            // If the array needs to grow. 
            if (_items.Length == _size)
            {
                GrowArray(1);
            }

            // Since we know the array isn't full and _head is greater than 0, 
            // we know the slot in front of head is open. 
            if (_head > 0)
            {
                _head--;
            }
            else
            {
                // Otherwise we need to wrap around to the end of the array. 
                _head = _items.Length - 1;
            }
            _items[_head] = item;

            _size++;
        }

        public void EnqueueLast(T item)
        {
            // If the array needs to grow. 
            if (_items.Length == _size)
            {
                GrowArray(0);
            }
            // Now we have a properly sized array and can focus on wrapping issues. 
            // If _tail is at the end of the array we need to wrap around. 
            if (_tail == _items.Length - 1)
            {
                _tail = 0;
            }
            else
            {
                _tail++;
            }
            _items[_tail] = item;
            _size++;
        }

        public T DequeueFirst()
        {
            if (_size == 0)
            {
                throw new InvalidOperationException("The deque is empty");
            }
            T value = _items[_head];
            if (_head == _items.Length - 1)
            {
                // If the head is at the last index in the array, wrap it around. 
                _head = 0;
            }
            else
            {
                // Move to the next slot.
                _head++;
            }
            _size--;
            return value;
        }
    }
}

