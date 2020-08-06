using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm.Traversal
{
    public class DepthFirstSearch
    {
        public List<int> DFSInOrder(Node node)
        {
            List<int> result = new List<int>();


            return traverseInOrder(node, result);
        }

        public void DFSPostOrder()
        {
        }

        public void DFSPreOrder()
        {
        }

        public List<int> traverseInOrder(Node node, List<int> data)
        {
            if(node.left != null)
                traverseInOrder(node.left, data);
            data.Add(node.value);

            if(node.right != null)
                traverseInOrder(node.right, data);

            return data;
        }
    }
}
