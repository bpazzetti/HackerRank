using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace HackerRank.Sorting
{
    class BigSorting
    {

        public static void WriteLines<T>(IEnumerable<T> array)
        {
            foreach (var a in array)
                Console.WriteLine(a);
        }

        static void Main1(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] unsorted = new string[n];
            for (int unsorted_i = 0; unsorted_i < n; unsorted_i++)
            {
                unsorted[unsorted_i] = Console.ReadLine();
            }
            Array.Sort<string>(unsorted,
                    delegate (string s1, string s2)
                    {
                        if (s1.Length > s2.Length) return 1;
                        if (s1.Length < s2.Length) return -1;
                        for (int i = 0; i < s1.Length; i++)
                        {
                            if (s1[i] > s2[i]) return 1;
                            if (s1[i] < s2[i]) return -1;
                        }
                        return 0;
                    });
            WriteLines(unsorted);
        }
    }
}