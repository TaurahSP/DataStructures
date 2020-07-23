using Algorithm.Recursion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            var factorial = new Factorial().findFactorialIterative(4);
            var recursive = new Factorial().findFactorialRecursive(4);
        }
    }
}
