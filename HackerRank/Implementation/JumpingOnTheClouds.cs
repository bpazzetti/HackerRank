using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Algorithms.Implementation
{
    class JumpingOnTheClouds
    {

        static void Main1(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] c_temp = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(c_temp, Int32.Parse);

            int count = -1;
            for (int i = 0; i < n; i++, count++)
            {
                if (i < n - 2 && c[i + 2] == 0) i++;
            }
            Console.WriteLine(count);
        }
    }
}