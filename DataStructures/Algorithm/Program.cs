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
            MergeSort sort = new MergeSort();
            int[] array = new int[] { 6, 7, 8, 5 };
            sort.mergesort(array);
        }
    }
}
