namespace Algorithm.Sorting
{
    /// <summary>
    /// implementation of selection sort O(n^2)
    /// </summary>
    public class SelectionSort
    {
        public void sort(int [] unsortedlist)
        {
            for(int i = 0; i < unsortedlist.Length; i++)
            {
                int indexminimum = i;

                for(int j = i + 1; j < unsortedlist.Length; j++)
                {
                    if(unsortedlist[j] < unsortedlist[indexminimum])
                    {
                        indexminimum = j;
                    }
                }
                var temp = unsortedlist[i];
                unsortedlist[i] = unsortedlist[indexminimum];
                unsortedlist[indexminimum] = temp;
            }
        }
    }
}
