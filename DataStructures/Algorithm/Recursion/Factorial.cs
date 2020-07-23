using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Recursion
{
    /// <summary>
    /// write two functions that finds the factorial of any number. one should use recursive,the other should jsut use a
    /// for loop
    /// </summary>
    public class Factorial
    {
        public int findFactorialRecursive(int number) { return number; }

        /// <summary>
        /// fucntion to find factorial of a number using for loop
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public int findFactorialIterative(int number)
        {
            if(number == 1)
                return 1;

            int factorial = 1;

            for(int i = number; i > 1; i--)
            {
                factorial = factorial * i;
            }

            return factorial;
        }
    }
}
