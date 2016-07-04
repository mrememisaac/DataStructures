using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    /// <summary>
    /// A collection that returns objects to the caller in a Last-In-First-Out sequence
    /// Stacks cannot be indexed directly
    /// Lack a contains method
    /// Is not enumerable
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Stack<T>
    {
        DoublyLinkedList<T> _items = new DoublyLinkedList<T>();

        public T Pop()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty");
            }
            T last = _items.Tail.Value;

            _items.RemoveLast();
            
            return last;
        }

        public void Push(T item)
        {
            _items.AddLast(item);
        }

        public T Peek()
        {
            if(_items.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty");
            }
            return _items.Tail.Value;
        }

        public int Count
        {
            get
            {
                return _items.Count;
            }
        }

    }
}
