using DataStructures.Arrays;
using DataStructures.HashTable;
using DataStructures.LinkedList;
using System;
using System.Linq;

namespace DataStructures
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Array
            //var Array = new ArrayImplementation();
            //Array.push("hi");
            //Array.push("you");
            //Array.push("!");
            //Array.delete(2);

            //for (int i = 0; i < Array.length; i++)
            //{
            //    Console.WriteLine(Array.get(i));
            //}
            //for (int i = 0; i < Array.length; i++)
            //{
            //    Console.WriteLine(Array.get(i));
            //}
            //Array.pop();
            //Console.ReadLine(); 
            #endregion

            #region ReverseString
            //ReverseString reverseString = new ReverseString();
            //Console.WriteLine(reverseString.reverse("My  name  is keshav"));
            //Console.ReadLine(); 
            #endregion

            #region MergeArrays
            //MergeArrays mergeArrays = new MergeArrays();
            //int[] a = new int[] { 1, 4, 8, 20 };
            //int n1 = a.Length;

            //int[] b = new int[] { 17, 21 };
            //int n2 = b.Length;

            //int[] arr3 = new int[n1 + n2];

            //mergeArrays.mergesortedarray(a, b, n1, n2, arr3);

            //Console.Write("Array after merging\n");
            //for (int i = 0; i < n1 + n2; i++)
            //    Console.Write(arr3[i] + " "); 
            #endregion

            #region HashTable
            //HashTable.HashTable h = new HashTable.HashTable(2);
            //h.set("grapes", 1000);
            //h.set("apples", 54);
            //h.keys(); 
            #endregion

            #region RecurringInteger
            //RecurringInteger recurring = new RecurringInteger();
            //int[] array = new int[] { 1, 3, 3, 5 };
            //recurring.findrecurring(array); 
            #endregion

            #region DoubleLinkedList
            //DoublyLinkedList d = new DoublyLinkedList(10);
            //d.append(7);
            //d.append(16);
            //d.prepend(5);
            //d.insert(1, 99);
            //d.remove(1);

            //d.printList(); 
            #endregion

            var stack = new DataStructures.Stack.Stack();
            stack.push(1);
            stack.push(2);
            stack.pop();
            stack.pop();
        }
    }
}
