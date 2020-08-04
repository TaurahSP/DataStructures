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

            BreadthFirstSearch bfs = new BreadthFirstSearch();
            var result = bfs.breathFirstSearch(tree.root);
            foreach(var item in result)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();
        }
    }
}
