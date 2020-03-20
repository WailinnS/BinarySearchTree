using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class BST<T> where T : IComparable
    {
        public BstNode<T> RootNode { get; set; }
        public BST()
        {
            RootNode = null;
        }


        public BstNode<T> Search(T data)
        {
            BstNode<T> current = RootNode;
            while (current != null)
            {
                if (data.CompareTo(current.Value) < 0)
                {
                    current = current.LeftChild;
                }
                else if (data.CompareTo(current.Value) > 0)
                {
                    current = current.RightChild;
                }
                else if (data.CompareTo(current.Value) == 0)
                {
                    return current;
                }
            }

            return null;
        }

        public bool Contains(T data)
        {
            return Search(data) != null;
        }


        //adds a value to the tree.
        public void Insert(T data)
        {

            if (RootNode == null)
            {
                RootNode = new BstNode<T>(data);
            }
            else
            {
                BstNode<T> current = RootNode;
                bool done = false; //lets us exit the loop when a leaf is added.
                while (!done)
                {
                    //check left
                    if (data.CompareTo(current.Value) < 0)
                    {
                        if (current.LeftChild == null)
                        {
                            current.LeftChild = new BstNode<T>(data, current);
                            done = true;
                        }
                            current = current.LeftChild;
                            
                        
                    }
                    else //check right
                    {
                        if (current.RightChild == null)
                        {
                            current.RightChild = new BstNode<T>(data, current);
                            done = true;
                        }
                       
                            current = current.RightChild; 
                        
                    }
                }
            }

           
            ////check if the tree has a root, if so, add to the tree,
            //if(RootNode != null)
            //{
            //    RootNode.Insert(data);
            //}
            //else
            //{
            //    //otherwise, the value becomes the root.
            //    Console.WriteLine($"Inserted {data}");
            //    RootNode = new BstNode<T>(data);
            //}
        }

        public BstNode<T> Minimun()
        {
            BstNode<T> current = RootNode;
            while (current.LeftChild != null)
            {
                current = current.LeftChild;
            }
            return current;
        }

        public BstNode<T> Maximum()
        {
            BstNode<T> current = RootNode;
            while(current.RightChild != null)
            {
                current = current.RightChild;
            }
            return current;
        }

    }
}
