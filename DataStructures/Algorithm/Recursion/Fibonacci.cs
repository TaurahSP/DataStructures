using System;
using System.Linq;

namespace Algorithm.Recursion
{
    /// <summary>
    /// Given a number N return the index value of the Fibonacci sequence,where the sequence is:
    /// 0,1,1,2,3,5,8,13,21,34,55,89,144... the pattern of the sequence is that each value is the sum of the 2 previous
    /// values,that means taht N=5 =>2+3
    /// </summary>
    public class Fibonacci
    {
        //O(2^n)
        public int FibonacciRecursive(int number)
        {
            if(number < 2)
            {
                return number;
            }
            return FibonacciRecursive(number - 1) + FibonacciRecursive(number - 2);
        }

        //o(n)
        public int FibonacciIterative(int number)
        {
            int first = 0;
            int second = 1;
            int third = 0;

            if(number == 1)
                return first;

            if(number == 2)
                return second;

            if(number == 3)
                return first + second;

            while(number != 1)
            {
                third = first + second;
                first = second;
                second = third;
                number--;
            }

            return third;
        }
    }
}
