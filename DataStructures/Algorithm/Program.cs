using Algorithm.Traversal;
using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.insert(9);
            tree.insert(4);
            tree.insert(6);
            tree.insert(20);
            tree.insert(170);
            tree.insert(15);
            tree.insert(1);

            DepthFirstSearch bfs = new DepthFirstSearch();
            var result = bfs.DFSInOrder(tree.root);
            foreach(var item in result)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();
        }
    }
}
