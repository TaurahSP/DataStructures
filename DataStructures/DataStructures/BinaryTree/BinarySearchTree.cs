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
            if(root == null)
            {
                return;
            }

            Node nodeToRemove = root;
            Node parentNode = null;
            while(nodeToRemove.value != value)
            { //Searching for the node to remove and it's parent
                parentNode = nodeToRemove;
                if(value < nodeToRemove.value)
                {
                    nodeToRemove = nodeToRemove.left;
                } else if(value > nodeToRemove.value)
                {
                    nodeToRemove = nodeToRemove.right;
                }
            }

            Node replacementNode = null;
            if(nodeToRemove.right != null)
            { //We have a right node
                replacementNode = nodeToRemove.right;
                if(replacementNode.left == null)
                { //We don't have a left node
                    replacementNode.left = nodeToRemove.left;
                } else
                { //We have a have a left node, lets find the leftmost
                    Node replacementParentNode = nodeToRemove;
                    while(replacementNode.left != null)
                    {
                        replacementParentNode = replacementNode;
                        replacementNode = replacementNode.left;
                    }
                    replacementParentNode.left = null;
                    replacementNode.left = nodeToRemove.left;
                    replacementNode.right = nodeToRemove.right;
                }
            } else if(nodeToRemove.left != null)
            {//We only have a left node
                replacementNode = nodeToRemove.left;
            }

            if(parentNode == null)
            {
                root = replacementNode;
            } else if(parentNode.left == nodeToRemove)
            { //We are a left child
                parentNode.left = replacementNode;
            } else
            { //We are a right child
                parentNode.right = replacementNode;
            }
        }
    }
}
