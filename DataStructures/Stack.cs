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
        LinkedList<T> _items = new LinkedList<T>();


    }
}
