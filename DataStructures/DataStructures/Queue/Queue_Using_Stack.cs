using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Queue
{
/// <summary>
/// Implement a queue using a stack
/// </summary>
        public class Queue_Using_Stack
        {
            private Stack<int> stack = new Stack<int>();
            private Stack<int> auxiliaryStack = new Stack<int>();

            public int peek()
            {
                fillAuxiliaryStackWithStack();
                int value = auxiliaryStack.Peek();
                fillStackWithAuxiliaryStack();
                return value;
            }

            public void enqueue(int value) { this.stack.Push(value); }

            public int dequeue()
            {
                fillAuxiliaryStackWithStack();
                int value = auxiliaryStack.Pop();
                fillStackWithAuxiliaryStack();
                return value;
            }

            public void printQueue()
            {
                if(stack.Count == 0)
                {
                    return;
                }

                fillAuxiliaryStackWithStack();
                foreach(var i in auxiliaryStack)
                {
                    Console.Write("-->" + i);
                }
                Console.WriteLine();
                fillStackWithAuxiliaryStack();
            }

            private void fillAuxiliaryStackWithStack()
            {
                while(stack.Count > 0)
                { //Making the "auxiliaryStack" stack as queue of "Stack"
                    auxiliaryStack.Push(stack.Pop());
                }
            }

            private void fillStackWithAuxiliaryStack()
            {
                while(auxiliaryStack.Count > 0)
                { //Return stack to the original state
                    stack.Push(auxiliaryStack.Pop());
                }
            }
        }
}
