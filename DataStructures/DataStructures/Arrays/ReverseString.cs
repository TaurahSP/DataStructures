using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    /// <summary>
    /// This class demonstrate a way to reverse a string
    /// </summary>
    public class ReverseString
    {
        public String reverse(string str)
        {
            if(str.Length < 2)
            {
                return "Enter string greater than 2 characters";
            }
            string result = string.Empty;

            for(int i = str.Length - 1; i >= 0; i--)
            {
                result += str[i];
            }

            return result;
        }
    }
}
