using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class LinkedList<T> : ICollection<T>
    {
        protected LinkedListNode<T> _head;
        protected LinkedListNode<T> _tail;        

        public void Add(T item)
        {
            if (item == null) //if item is null do nothing
            {
                return;
            }

            //1. Create a new linked list node
            LinkedListNode<T> node = new LinkedListNode<T>(item); 

            //2. Find the last node in this list
            if (_head == null) //if list did not exist create new 
            {
                _head = node;
                _tail = node;
            }
            else
            {   
                _tail.Next = node;
                _tail = node;
            }
            Count++;
        }

        public void Clear()
        {
            _head = null;
            _tail = null;
            Count = 0; //reset counter
        }
                
        public bool Contains(T item)
        {            
            LinkedListNode<T> current = _head;
            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            var current = _head;
            while (current != null)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }

        public int Count
        {
            get;
            protected set;
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(T item)
        {
            //if the item is null
            if (item == null)
            {
                return false;
            }

            //if theres no item in the list
            if (Count == 0)
            {
                return false;
            }

            //if theres only one item in the list
            if (_head == _tail && _head.Value.Equals(item))
            {
                _head = _tail = null;
                Count--;
                return true;
            }

            //if item = head
            if (_head.Value.Equals(item))
            {
                _head = null; //nullify the head
                _head = _head.Next; //point the head to the next                
                Count--;
                return true;
            }

            //if item is somewhere after the head
            LinkedListNode<T> previous = null; //
            var current = _head.Next;
            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    previous.Next = current.Next; //update the pointer
                    current = null; //nullify to remove

                    //if previous.nex == null ie end of line
                    if (previous.Next == null)
                    {
                        _tail = previous; //update the tail
                    }
                    Count--;
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> current = _head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }
    }
}
