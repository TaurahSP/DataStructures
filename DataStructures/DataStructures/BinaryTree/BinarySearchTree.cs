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

        public Node Lookup(int value)
        {
            if(value == root.value)
            {
                return root;
            }

            Node temp = root;

            while(temp != null)
            {
                if(value <= temp.value)
                {
                    if(temp.left.value == value)
                    {
                        return temp.left;
                    }
                    temp = temp.left;
                } else
                {
                    if(temp.right.value == value)
                    {
                        return temp.right;
                    }
                    temp = temp.right;
                }
            }

            return null;
        }

        public void remove(int value)
        {
            //get node of the value to remove
            var removenode = Lookup(value);

            if(removenode == null)
            {
                return;
            }

            //checking if leaf node
            if(removenode.left == null && removenode.right == null)
            {
                removenode = null;
                return;
            }

            //if no right node 
            if(removenode.right == null)
            {
                removenode = removenode.left;
                return;
            }

            //Go to right node and find left most node
            var temp = removenode.right;

            while(temp.left != null)
            {
                temp = temp.left;
            }
            //replacing node to remove with left most value
            var pointernode = removenode;
            removenode.value = temp.value;
            removenode.right = pointernode.right;
            removenode.left = pointernode.left;

            //check if node has right child
            if(temp.right == null)
            {
                temp = null;
                return;
            }
            //replacing leftmost value with its right node
            temp = temp.right;
        }
    }
}
