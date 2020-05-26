using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Algorithms.Implementation
{
    class StrangeCounter
    {

        static void Main1(String[] args)
        {
            long t = Convert.ToInt64(Console.ReadLine());
            long n = 2;
            while (3 * (n - 1) < t)
            {
                n = 2 * n;
            }
            Console.WriteLine((3 * (n - 1) - t + 1));
        }
    }
}