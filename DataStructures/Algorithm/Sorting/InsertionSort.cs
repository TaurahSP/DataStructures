using System;
using System.Linq;

namespace Algorithm.Sorting
{
    public class InsertionSort
    {
        public void sort(int[] initiallist)
        {
            for(int i = 0; i < initiallist.Length - 1; i++)
            {
                if(initiallist[i + 1] < initiallist[i])
                {
                    for(int j = 0; j <= i; j++)
                    {
                        if(initiallist[i + 1] < initiallist[j])
                        {
                            int min = initiallist[j];

                            initiallist[j] = initiallist[i + 1];

                            initiallist[i + 1] = min;
                        }
                    }
                }
            }
        }
    }
}
