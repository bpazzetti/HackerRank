using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Algorithms.Implementation
{
    class ElectronicsShop
    {

        static void Main1(String[] args)
        {
            string[] tokens_s = Console.ReadLine().Split(' ');
            int s = Convert.ToInt32(tokens_s[0]);
            int n = Convert.ToInt32(tokens_s[1]);
            int m = Convert.ToInt32(tokens_s[2]);
            string[] keyboards_temp = Console.ReadLine().Split(' ');
            int[] keyboards = Array.ConvertAll(keyboards_temp, Int32.Parse);
            string[] drives_temp = Console.ReadLine().Split(' ');
            int[] drives = Array.ConvertAll(drives_temp, Int32.Parse);
            Array.Sort<int>(keyboards,
                    delegate (int a, int b)
                    {
                        return b - a; //Normal compare is a-b
                });
            //Array.Reverse(keyboards);
            Array.Sort(drives);
            //int iMax = -1;
            //int jMax = -1;
            int max = -1;
            for (int i = 0, j = 0; i < n; i++)
            {
                for (; j < m; j++)
                {
                    if (keyboards[i] + drives[j] > s) break; //This prevents j from incrementing
                    if (keyboards[i] + drives[j] > max)
                    {
                        max = keyboards[i] + drives[j];
                        /*iMax = keyboards[i];
                        jMax = drives[j];*/
                        /*iMax = i;
                        jMax = j;*/
                    }
                }
            }

            Console.WriteLine(max);
            /*Console.WriteLine(iMax);
            Console.WriteLine(jMax);*/
        }
    }
}