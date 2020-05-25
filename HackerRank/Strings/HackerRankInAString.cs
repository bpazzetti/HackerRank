using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace HackerRank.Strings
{
    class HackerRankInAString
    {
        static void Main1(String[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());
            string pattern = @"hackerrank";
            for (int a0 = 0; a0 < q; a0++)
            {
                string s = Console.ReadLine();
                bool match = true;
                int lastIndex = 0;
                for (int i = 0; i < pattern.Length && match; i++)
                {
                    int j = s.IndexOf(pattern[i], lastIndex);
                    /*Console.WriteLine("j = {0}, pattern[i]={1}", j, pattern[i]);*/
                    match = j > -1;
                    if (j >= lastIndex)
                        lastIndex = j + 1;
                }

                if (match)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}