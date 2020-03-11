using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class Node<T>
    {
        public T Value { get; set; }

        public Node<T> LeftChild { get; set; }
        public Node<T> RightChild { get; set; }
        public Node<T> Parent { get; set; }

        public bool IsLeftChild
        {
            get
            {
                return Parent == null ? false : Parent.LeftChild == this;
            }
        }
        public bool IsRightChild
        {
            get
            {
                return Parent == null ? false : Parent.RightChild == this;
            }
        }


        public Node(T value)
        {
            Value = value;
        }

        


    }
}
