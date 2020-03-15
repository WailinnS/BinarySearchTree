using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class BinarySearchTree<T> where T : IComparable
    {
        public Node<T> RootNode { get; set; }

        public Node<T> Search(Node<T> node,T data)
        {
            Node<T> current = node;

            if (current != null)
            {
                return null;
            }
            if (current.Value.Equals(data))
            {
                return current;
            }
            //check lseft
            if (current.Value.CompareTo(data) == -1)
            {
                current = current.LeftChild;
                Search(current,current.Value);
            }
            else //check right
            {
                current = current.RightChild;
                Search(current,current.Value);
            }

            return current;
        }

        public void Insert(T data)
        {

        }
    }
}
