using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Algorithms.Implementation
{
    class BreakingTheRecords
    {

        static int[] getRecord(int[] s)
        {
            // Complete this function
            int[] result = new int[2];
            int iMax = 0;
            int iMin = 1;
            int iresMax = s[0];
            int iresMin = s[0];

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] > iresMax)
                {
                    result[iMax]++;
                    iresMax = s[i];
                }
                if (s[i] < iresMin)
                {
                    result[iMin]++;
                    iresMin = s[i];
                }
            }
            return result;
        }

        static void Main1(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] s_temp = Console.ReadLine().Split(' ');
            int[] s = Array.ConvertAll(s_temp, Int32.Parse);
            int[] result = getRecord(s);
            Console.WriteLine(String.Join(" ", result));
        }
    }
}