using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class BinarySearchTree<T> where T : IComparable 
    {
        public Node<T> RootNode { get; set; }

        public Node<T> Search(T data)
        {
            Node<T> current = RootNode;
            while(!current.Value.Equals(data))
            {
                if(current != null)
                {
                    if(current.Value > data)
                    {

                    }
                }
            }
        }
    }
}
