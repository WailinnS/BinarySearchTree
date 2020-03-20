using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class BstNode<T> where T: IComparable
    {
       
        public T Value { get; set; }

        public BstNode<T> LeftChild { get; set; }
        public BstNode<T> RightChild { get; set; }
        public BstNode<T> Parent { get; set; }

       
        //for soft deletion.
        public bool IsDeleted { get; set; }

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


        //constructor
        public BstNode(T value, BstNode<T> parent = null)
        {
            Value = value;
            Parent = parent;
        }

        





        ////recursively called down the tree until it findsss an open spot.
        ////ToDo Note: Currently im checking right to left instead of left to right.
        //public void Insert(T value)
        //{
        //    //if the value is greater than or equal to node value., insert right
        //    if(value.CompareTo(Value) > 0 || value.CompareTo(Value) == 0) 
        //    {
        //        if(RightChild == null)
        //        {
        //            Console.WriteLine($"Inserted {value}");
        //            RightChild = new BstNode<T>(value);
        //        }
        //        else
        //        {
        //            RightChild.Insert(value);
        //        }
        //    }
        //    else
        //    {
        //        //if the value is less than the current node value, insert left
        //        if(LeftChild == null)
        //        {
        //            Console.WriteLine($"Inserted {value}");
        //            LeftChild = new BstNode<T>(value);
        //        }
        //        else
        //        {
        //            LeftChild.Insert(value);
        //        }
        //    }
        //}

       
    }
}
