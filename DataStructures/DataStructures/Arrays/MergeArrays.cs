﻿namespace DataStructures.Arrays
{
    /// <summary>
    /// Problem: merge two sorted arrays into one
    /// </summary>
    class MergeArrays
    {
        public  void mergeArrays(int[] arr1, int[] arr2, int n1, int n2, int[] arr3)
        {
            int i = 0, j = 0, k = 0;

            while (i < n1 && j < n2)
            {
                if (arr1[i] < arr2[j])
                    arr3[k++] = arr1[i++];
                else
                    arr3[k++] = arr2[j++];
            }

            while (i < n1)
                arr3[k++] = arr1[i++];

            while (j < n2)
                arr3[k++] = arr2[j++];
        }
    }
}
