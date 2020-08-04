﻿using System.Collections.Generic;
using System.Xml;

namespace Algorithm.Traversal
{
    public class BreadthFirstSearch
    {
        //Iterative
        public  List<int> breathFirstSearch(Node currentNode)
        {
            List<int> list = new List<int>();
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(currentNode);

            while(queue.Count > 0)
            {
                currentNode = queue.Dequeue();
                list.Add(currentNode.value);
                if(currentNode.left != null)
                {
                    queue.Enqueue(currentNode.left);
                }

                if(currentNode.right != null)
                {
                    queue.Enqueue(currentNode.right);
                }
            }
            return list;
        }

        //Recurcive
        public  List<int> breathFirstSearchR(Queue<Node> queue, List<int> list)
        {
            if(queue.Count == 0)
            {
                return list;
            }

            var currentNode = queue.Dequeue();
            list.Add(currentNode.value);
            if(currentNode.left != null)
            {
                queue.Enqueue(currentNode.left);
            }

            if(currentNode.right != null)
            {
                queue.Enqueue(currentNode.right);
            }

            return breathFirstSearchR(queue, list);
        }
    }

    public class Node
    {
        public Node left { get; set; }

        public Node right { get; set; }

        public int value { get; set; }

        public Node(int value)
        {
            this.left = null;
            this.right = null;
            this.value = value;
        }
    }

    class BinarySearchTree
    {
        public Node root;
        public BinarySearchTree() { this.root = null; }

        public void insert(int value)
        {
            Node newNode = new Node(value);
            if(this.root == null)
            {
                this.root = newNode;
                return;
            }

            Node currentNode = this.root;
            while(true)
            {
                if(currentNode.value > value)
                {
                    if(currentNode.left == null)
                    {
                        currentNode.left = new Node(value);
                        return;
                    }
                    currentNode = currentNode.left;
                } else
                {
                    if(currentNode.right == null)
                    {
                        currentNode.right = new Node(value);
                        return;
                    }
                    currentNode = currentNode.right;
                }
            }
        }
    }
}
