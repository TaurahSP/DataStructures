using System;
using System.Linq;

namespace Algorithm.Sorting
{
    public class MergeSort
    {
        public int[] mergesort(int[]initiallist)
        {
            if(initiallist.Length == 1)
            {
                return initiallist;
            }

            //split array
            int half = (initiallist.Length / 2);
            int halfindex = half - 1;
            int righthalf = initiallist.Length - half;
            int[] left = new int[half];
            int[] right = new int[righthalf];

            for(int i = 0; i <= halfindex; i++)
            {
                left[i] = initiallist[i];
            }

            int j = 0;

            for(int i = half; i < initiallist.Length; i++)
            {

                right[j++] = initiallist[i];
            }
            return merge(mergesort(left), mergesort(right));
        }

        public int[] merge(int[] left, int [] right)
        {
            if(right.Length == 0)
                return left;
            int [] temp = new int[right.Length + left.Length];

            for(int i = 0; i < right.Length; i++)
            {
                if(right[i] < left[i])
                {
                    temp[i] = left[i];
                } else
                {
                    temp[i] = right[i];
                }
            }

            return temp;
        }
    }
}
