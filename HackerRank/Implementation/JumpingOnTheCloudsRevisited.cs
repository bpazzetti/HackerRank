using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Algorithms.Implementation
{
    class JumpingOnTheCloudsRevisited
    {

        static void Main1(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] c_temp = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(c_temp, Int32.Parse);
            int energy = 100;
            for (int i = 0; i < c.Length; i = i + k)
            {
                if (c[i] == 0)
                    energy--;
                else
                    energy = energy - 3;
            }
            Console.WriteLine(energy);
        }
    }
}