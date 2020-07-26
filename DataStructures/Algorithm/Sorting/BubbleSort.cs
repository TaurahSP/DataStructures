namespace Algorithm.Sorting
{
    /// <summary>
    /// implementation of bubble sort O(n^2)
    /// </summary>
    public class BubbleSort
    {
        public void sort(int[] unsortedlist)
        {
            for(int i = 0; i < unsortedlist.Length; i++)
            {
                for(int j = 0; j < unsortedlist.Length - 1; j++)
                {
                    if(unsortedlist[j] > unsortedlist[j + 1])
                    {
                        var temp = unsortedlist[j];
                        unsortedlist[j] = unsortedlist[j + 1];
                        unsortedlist[j + 1] = temp;
                    }
                }
            }
        }
    }
}
