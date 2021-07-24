using System;

namespace BinarySearchTreeProgram
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("<--------Welcome to Binary Search Tree Program-------->");
            Console.WriteLine("-------------------------------------------------------");
            // Creating object
            BinarySearchTree<int> tree = new BinarySearchTree<int>(56);

            tree.Insert(30);
            tree.Insert(70);
            tree.DisplayBST();
        }
    }
}
