using System;
using System.Linq;

namespace Algorithm.Recursion
{
    /// <summary>
    /// reverse a string using recursion
    /// </summary>
    public class ReverseString
    {
        public  String reverseStringRecursively(string str)
        {
            if(str.Length == 0)
            {
                return string.Empty;
            }
            return reverseStringRecursively(str.Substring(1)) + str[0];
        }
    }
}
