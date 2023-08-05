using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class BinarySearchClass<T> : BinaryTree<T> where T : IComparable
    {
        // Add method to insert a new node with the given value in the correct location
        public void Add(T value)
        {
            Root = AddNode(Root, value);
        }

        private Node<T> AddNode(Node<T> node, T value)
        {
            if (node == null)
                return new Node<T>(value);

            if (value.CompareTo(node.Value) < 0)
                node.Left = AddNode(node.Left, value);
            else if (value.CompareTo(node.Value) > 0)
                node.Right = AddNode(node.Right, value);

            return node;
        }

        // Contains method to check if the value is present in the tree
        public bool Contains(T value)
        {
            return ContainsNode(Root, value);
        }

        private bool ContainsNode(Node<T> node, T value)
        {
            if (node == null)
                return false;

            int comparison = value.CompareTo(node.Value);
            if (comparison == 0)
                return true;
            else if (comparison < 0)
                return ContainsNode(node.Left, value);
            else
                return ContainsNode(node.Right, value);
        }
    }
}
