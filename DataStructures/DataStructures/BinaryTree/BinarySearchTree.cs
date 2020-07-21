using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinaryTree
{
    public class BinarySearchTree
    {
        public Node root;

        public BinarySearchTree() { this.root = null; }

        public void insert(int value)
        {
            Node newnode = new Node(value);


            if(root == null)
            {
                root = newnode;
                return;
            }

            Node temp = root;

            while(temp != null)
            {
                if(value <= temp.value)
                {
                    if(temp.left == null)
                    {
                        temp.left = newnode;
                        return;
                    }
                    temp = temp.left;
                } else
                {
                    if(temp.right == null)
                    {
                        temp.right = newnode;
                        return;
                    }
                    temp = temp.right;
                }
            }
        }

        public int Lookup(int value)
        {
            if(value == root.value)
            {
                return value;
            }

            Node temp = root;

            while(temp != null)
            {
                if(value <= temp.value)
                {
                    if(temp.left.value == value)
                    {
                        return value;
                    }
                    temp = temp.left;
                } else
                {

                    if(temp.right.value == value)
                    {
                        return value;
                    }
                    temp = temp.right;
                }
            }

            return -1111111111;
        }
    }
}
