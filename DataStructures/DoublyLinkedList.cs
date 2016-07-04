using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class DoublyLinkedList<T> : LinkedList<T>
    {
        /// <summary>
        /// Exposed to allow the consumer walk down the list
        /// </summary>
        public LinkedListNode<T> Head
        {
            get
            {
                return this._head;
            }
        }

        /// <summary>
        /// Exposed to allow the consumer walk up the list
        /// </summary>
        public LinkedListNode<T> Tail
        {
            get
            {
                return this._tail;
            }
        }

        /// <summary>
        /// Add to top of list
        /// </summary>
        /// <param name="item"></param>
        public void AddFirst(T item)
        {
            //create the new node
            LinkedListNode<T> node = new LinkedListNode<T>(item);

            //save the head to a new location
            LinkedListNode<T> temp = _head;

            //if list is null
            if (_head == null)
            {
                _head = node;
                _tail = _head;
            }
            else //if(_head == _tail) //1 item list
            {
                //make it the new head
                _head = node;

                //make the new head point to the old head as next
                _head.Next = temp;

                //make the former head refer to it  as previous
                temp.Previous = _head;
            }
            Count++;
        }

        /// <summary>
        /// Add to bottom of list
        /// </summary>
        /// <param name="item"></param>
        public void AddLast(T item)
        {
            //create the new node
            LinkedListNode<T> node = new LinkedListNode<T>(item);

            if (Count == 0) //empty list, set head and tail to new node
            {
                _head = _tail = node;
            }
            else
            {
                //non-empty list so set current tail to have a next
                _tail.Next = node;

                //set the current tail to the new lasts previous
                node.Previous = _tail;

                //set the new node as tail
                _tail = node;
            }
            Count++; //update the item count
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool RemoveFirst()
        {
            //if list is empty
            if (Count == 0 || _head == null)
            {
                return false;
            }

            //if single element
            if (Count == 1)
            {
                _head = _tail = null;                                
            }
            else
            {                
                //set second to head
                _head = _head.Next;

                //set second previous to null
                _head.Previous = null;
            }
            //update count
            Count--;

            return true;
        }

        public bool RemoveLast()
        {
            if (Count == 0 || _tail == null)
            {
                return false;
            }
            if (Count == 1)
            {
                _head = _tail = null;                
            }
            else
            {
                //make the previous the new tail
                _tail = _tail.Previous;

                //make the new tails next null
                _tail.Next = null;                
            }
            //update count
            Count--;

            return true;
        }

        public bool Remove(T item)
        {
            if (item == null)
            {
                return false;
            }

            if (Count == 0)
            {
                return false;
            }            
            if (Count > 0)
            {
                //start searching from top
                var current = _head;

                while (current != null)
                {
                    if (current.Value.Equals(item))
                    {
                        //item found delete it which involves

                        //1. if it was a one item list reset the list
                        if (Count == 1)
                        {
                            _head = _tail = null;
                            Count = 0;
                        }

                        //2. if it was a next, update that pointer to the item after it, This is also handles tail update issues
                        if (current.Previous != null)
                        {
                            current.Previous.Next = current.Next;
                        }

                        //2. if it was a previous, update that pointer to the item before it
                        if (current.Next != null)
                        {
                            current.Next.Previous = current.Previous;
                        }

                        //if it was the tail
                        current = null;

                        //update count
                        Count--;

                        return true;
                    }
                    current = current.Next; //move to the next item
                }
            }
            return false;
        }
    }
}
