using Algorithm.Recursion;
using Algorithm.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            SelectionSort bubbleSort = new SelectionSort();
            int[] test = new int[] { 7, 8, 6, 3, 10, 1 };
            bubbleSort.sort(test);
        }
    }
}
