namespace DataStructures.Arrays
{
    /// <summary>
    /// Reverse an array by looping only through half the lenght
    /// </summary>
    public class ReverseArray
    {
        public void reverse(int[]initial)
        {
            for(int i = 0; i < initial.Length / 2; i++)
            {
                int index = initial.Length - i - 1;
                int temp = initial[i];
                initial[i] = initial[index];
                initial[index] = temp;
            }
        }
    }
}
