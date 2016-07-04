using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class LinkedListNode<T> 
    {
        /// <summary>
        /// The node value
        /// </summary>
        public T Value { get; internal set; } //set is internal to avoid illegal modification

        /// <summary>
        /// The next node in the linked list, returns null if this is last node
        /// </summary>
        public LinkedListNode<T> Next { get; internal set; } //set is internal to avoid illegal modification

        /// <summary>
        /// Points to the previous node, is null for the head node
        /// </summary>
        public LinkedListNode<T> Previous { get; internal set; } //set is internal to avoid illegal modification

        /// <summary>
        /// Creates a new LinkedListNode with the specified value
        /// </summary>
        /// <param name="value"></param>
        public LinkedListNode(T value)
        {
            Value = value;            
        }
    }
}
