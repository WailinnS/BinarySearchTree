using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*
                    Node:
                    -Value
                    -LeftChild
                    -RightChild
                    -Parent

                    -IsLeftChild
                    -IsRightChild
                    -ChildCount - count how many children
            */
            
            BST<int> binaryTree = new BST<int>();

            binaryTree.Insert(75);
            binaryTree.Insert(57);
            binaryTree.Insert(90);
            binaryTree.Insert(32);
            binaryTree.Insert(7);
            binaryTree.Insert(44);
            binaryTree.Insert(60);
            binaryTree.Insert(86);
            binaryTree.Insert(93);
            binaryTree.Insert(99);

            Console.WriteLine("end of insert");
            var min = binaryTree.Minimun();
            Console.WriteLine($"Finding smallest node...its value is: {min.Value}");
            var max = binaryTree.Maximum();
            Console.WriteLine($"Finding the max node...its value is: {max.Value}");

            /*TO DO: -Determine if a given node is a left child
             *       -Determine if a given node is a right chold
             *       -Add a delete*/

            ;
        }
    }
}
