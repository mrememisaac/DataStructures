using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Deque<T>
    {
        DoublyLinkedList<T> _items = new DoublyLinkedList<T>();

        public void EnqueueFirst(T value)
        {
            _items.AddFirst(value);
        }

        public void EnqueueLast(T value)
        {
            _items.AddLast(value);
        }

        public T DequeueFirst()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("Dequeu is empty");
            }
            T item = _items.Head.Value;
            _items.RemoveFirst();
            return item;
        }

        public T DequeueLast()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("Dequeu is empty");
            }
            T item = _items.Tail.Value;
            _items.RemoveLast();
            return item;
        }

        public T PeekFirst()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("Dequeu is empty");
            }
            return _items.Head.Value;            
        }

        public T PeekLast()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("Dequeu is empty");
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
