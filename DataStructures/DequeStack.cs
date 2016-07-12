using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    /// <summary>
    /// A stack based on the Deque class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DequeStack<T> : IStack<T>
    {
        Deque<T> _items = new Deque<T>();

        public void Push(T item)
        {
            _items.EnqueueLast(item);
        }

        public T Pop()
        {
            return _items.DequeueLast();
        }

        public T Peek()
        {
            return _items.PeekLast();
        }

        public int Count
        {
            get { return _items.Count; }
        }
    }
}
