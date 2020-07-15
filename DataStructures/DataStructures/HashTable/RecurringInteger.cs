using System.Collections;

namespace DataStructures.HashTable
{
    //find the first recurring integer in an array of integers
    public class RecurringInteger
    {
        public int findrecurring(int[]all)
        {
            Hashtable hashtable = new Hashtable();
            foreach(var item in all)
            {
                if(hashtable.ContainsKey(item))
                {
                    return item;
                }

                hashtable.Add(item, null);
            }
            return -12334;
        }
    }
}
