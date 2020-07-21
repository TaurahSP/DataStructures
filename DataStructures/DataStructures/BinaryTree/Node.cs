using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinaryTree
{
    public class Node
    {
        public Node right;
        public Node left;
        public int value;

        public Node(int value)
        {
            this.right = null;
            this.left = null;
            this.value = value;
        }
    }

}
