using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class BinaryTreeNode<Node> : IComparable<Node> where Node : IComparable<Node>
    {
        public Node Value { get; private set; }
        public BinaryTreeNode<Node> Left { get; set; }
        public BinaryTreeNode<Node> Right { get; set; }

        public BinaryTreeNode(Node value)
        {
            Value = value;
        }

        /// <summary>
        /// Compares the current node to the provided value
        /// </summary>
        /// <param name="other">The node value to compare to</param>
        /// <returns>1 if the instance value is greater than the provided value, -1 if less, or 0 if equal</returns>
        public int CompareTo(Node other)
        {
            return Value.CompareTo(other);
        }
    }
}
