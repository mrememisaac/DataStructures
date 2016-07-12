using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class BinaryTree<T> : IEnumerable<T> where T : IComparable<T>
    {
        BinaryTreeNode<T> _head;
        private int _count;

        public void Add(T value)
        {
            // Case 1: The tree is empty. Allocate the head. 
            if (_head == null) 
            {
                _head = new BinaryTreeNode<T>(value); 
            } 
            // Case 2: The tree is not empty, so recursively // find the right location to insert the node. 
            else
            { 
                AddTo(_head, value); 
            }            
            _count++;
        }

        // Recursive add algorithm. 
        private void AddTo(BinaryTreeNode<T> node, T value) 
        { 
            // Case 1: Value is less than the current node value 
            if (value.CompareTo(node.Value) < 0) 
            { 
                // If there is no left child, make this the new left, 
                if (node.Left == null) 
                {
                    node.Left = new BinaryTreeNode<T>(value); 
                } 
                else 
                { 
                    // else add it to the left node. 
                    AddTo(node.Left, value); 
                } 
            } 
            // Case 2: Value is equal to or greater than the current value.
            else 
            { 
                // If there is no right, add it to the right, 
                if (node.Right == null)
                { 
                    node.Right = new BinaryTreeNode<T>(value); 
                }
                else
                {
                    // else add it to the right node. 
                    AddTo(node.Right, value); 
                } 
            } 
        }

        public bool Contains(T value)
        {
            if (Compare(value, _head) == 0)
            {
                return true;
            }
            return false;
        }

        public int Compare(T value, BinaryTreeNode<T> current)
        {
            if (current == null)
            {
                return -1;
            }
            if (current.CompareTo(value) == 0)
            {
                return 0;
            }
            else if (current.CompareTo(value) > 0)
            {
                return Compare(value, current.Right);//result = current.Right.CompareTo(value);
            }
            else if (current.CompareTo(value) < 0)
            {
                return Compare(value, current.Left);//result = current.Left.CompareTo(value);
            }
            return -1;
        }

        public bool Remove(T value)
        {
            throw new NotImplementedException();
            //1. Find node to be removed
            //2. If node to be removed has no right child, move left child up
            //3. If node to be removed has a right child with no left child
            //4. If node to be removed has a right child with a left child
        }

        public void PreOrderTraversal(Action<T> action)
        {
            throw new NotImplementedException();
        }

        public void PostOrderTraversal(Action<T> action)
        {
            throw new NotImplementedException();
        }

        public void InOrderTraversal(Action<T> action)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get
            {
                return _count;
            }
        }
    }
}
