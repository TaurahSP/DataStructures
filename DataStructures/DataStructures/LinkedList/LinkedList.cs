using System;

namespace DataStructures.LinkedList
{
    public class DoubleNode
    {
        public int value { get; set; }

        public DoubleNode next { get; set; }

        public DoubleNode(int value)
        {
            this.value = value;
            this.next = null;
        }
    }

    public class LinkedList
    {
        private DoubleNode head;
        private DoubleNode tail;
        private int length;

        public LinkedList(int value)
        {
            this.head = new DoubleNode(value);
            this.tail = this.head;
            this.length = 1;
        }

        public void append(int value)
        {
            DoubleNode newNode = new DoubleNode(value);
            this.tail.next = newNode;
            this.tail = newNode;
            this.length++;
        }

        public void prepend(int value)
        {
            DoubleNode newNode = new DoubleNode(value);
            newNode.next = this.head;
            this.head = newNode;
            this.length++;
        }

        public void insert(int index, int value)
        {
            index = wrapIndex(index);
            if(index == 0)
            {
                prepend(value);
                return;
            }

            if(index == length - 1)
            {
                append(value);
                return;
            }

            DoubleNode newNode = new DoubleNode(value);

            DoubleNode leader = traverseToIndex(index - 1);
            DoubleNode holdingPointer = leader.next;

            leader.next = newNode;
            newNode.next = holdingPointer;
            this.length++;
        }

        public void remove(int index)
        {
            index = wrapIndex(index);
            if(index == 0)
            {
                head = head.next;
                return;
            }

            DoubleNode leader = traverseToIndex(index - 1);
            DoubleNode nodeToRemove = leader.next;
            leader.next = nodeToRemove.next;
            this.length--;
        }

        public void reverse()
        {
            DoubleNode first = head;
            tail = head;
            DoubleNode second = first.next;
            for(int i = 0; i < length - 1; i++)
            {
                DoubleNode temp = second.next;
                second.next = first;
                first = second;
                second = temp;
            }
            head.next = null;
            head = first;
        }

        public void printList()
        {
            if(this.head == null)
            {
                return;
            }
            DoubleNode current = this.head;
            while(current != null)
            {
                Console.Write("-->" + current.value);
                current = current.next;
            }
            Console.WriteLine();
        }

        public int getLength() { return this.length; }

        public DoubleNode getHead() { return this.head; }

        public DoubleNode getTail() { return this.tail; }

        private int wrapIndex(int index) { return Math.Max(Math.Min(index, this.length - 1), 0); }

        private DoubleNode traverseToIndex(int index)
        {
            int counter = 0;
            index = wrapIndex(index);
            DoubleNode currentNode = head;
            while(counter != index)
            {
                currentNode = currentNode.next;
                counter++;
            }
            return currentNode;
        }
    }
}
