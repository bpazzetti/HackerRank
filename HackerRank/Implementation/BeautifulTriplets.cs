using System;
using System.Collections.Generic;
using System.IO;

namespace Algorithms.Implementation
{
    class BeautifulTriplets
    {
        static void Main1(String[] args)
        {
            string[] s_temp = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(s_temp[0]);
            int d = Convert.ToInt32(s_temp[1]);
            s_temp = Console.ReadLine().Split(' ');
            int[] s = Array.ConvertAll(s_temp, Int32.Parse);
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                int I = Array.IndexOf(s, s[i] - d);
                int k = Array.IndexOf(s, d + s[i]);
                //Console.WriteLine("s[i]-d={0}, d+s[i]={1}, i,j,k ={0},{2},{1}", s[i]-d, d+s[i], i);
                if (I > -1 && k > -1)
                    count++;
            }
            Console.WriteLine(count);
        }
    }
}