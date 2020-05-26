using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Algorithms.Implementation
{
    class TheHurdleRace
    {

        static void Main1(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] height_temp = Console.ReadLine().Split(' ');
            int[] height = Array.ConvertAll(height_temp, Int32.Parse);
            int maxValue = height.Max();
            int dif = maxValue - k;
            if (dif > 0)
                Console.WriteLine(dif);
            else
                Console.WriteLine(0);
            // your code goes here
        }
    }
}