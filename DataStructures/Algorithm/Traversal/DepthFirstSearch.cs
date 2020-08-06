using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm.Traversal
{
    public class DepthFirstSearch
    {
        public Node root;
        public DepthFirstSearch() { this.root = null; }

        public List<int> DFSInOrder()
        {
            List<int> result = new List<int>();
            traverseInOrder(this.root, result);
            return result;
        }

        public List<int> DFSPreOrder()
        {
            List<int> result = new List<int>();
            traversePreOrder(this.root, result);
            return result;
        }

        public List<int> DFSPostOrder()
        {
            List<int> result = new List<int>();
            traversePostOrder(this.root, result);
            return result;
        }

        public List<int> traverseInOrder(Node node, List<int> list)
        {
            if(node.left != null)
            {
                traverseInOrder(node.left, list);
            }
            list.Add(node.value);
            if(node.right != null)
            {
                traverseInOrder(node.right, list);
            }

            return list;
        }

        public List<int> traversePreOrder(Node node, List<int> list)
        {
            list.Add(node.value);
            if(node.left != null)
            {
                traversePreOrder(node.left, list);
            }

            if(node.right != null)
            {
                traversePreOrder(node.right, list);
            }

            return list;
        }

        public List<int> traversePostOrder(Node node, List<int> list)
        {
            if(node.left != null)
            {
                traversePostOrder(node.left, list);
            }

            if(node.right != null)
            {
                traversePostOrder(node.right, list);
            }
            list.Add(node.value);

            return list;
        }
    }
}
