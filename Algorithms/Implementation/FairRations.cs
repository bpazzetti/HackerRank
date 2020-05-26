using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Algorithms.Implementation
{
    class FairRations
    {

        static void Main1(String[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            string[] B_temp = Console.ReadLine().Split(' ');
            int[] B = Array.ConvertAll(B_temp, Int32.Parse);
            int count = 0;
            for (int i = 0; i < N - 1; i++)
            {
                if (B[i] % 2 != 0)
                {
                    count += 2;
                    B[i]++;
                    B[i + 1]++;
                }
            }
            if (B[N - 1] % 2 != 0)
                Console.WriteLine("NO");
            else
                Console.WriteLine(count);
        }
    }
}