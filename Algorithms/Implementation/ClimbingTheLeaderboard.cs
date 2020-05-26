using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Algorithms.Implementation
{
    class ClimbingTheLeaderboard
    {

        public static void WriteArray<T>(IEnumerable<T> array) { Console.WriteLine(string.Join(" ", array)); }

        static void Main1(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] scores_temp = Console.ReadLine().Split(' ');
            int[] scores = Array.ConvertAll(scores_temp, Int32.Parse);
            int m = Convert.ToInt32(Console.ReadLine());
            string[] alice_temp = Console.ReadLine().Split(' ');
            int[] alice = Array.ConvertAll(alice_temp, Int32.Parse);
            List<int> list = new List<int>();
            list.Add(scores[0]);
            int last = scores[0];
            for (int i = 0; i < n; i++)
            {
                if (last != scores[i])
                {
                    list.Add(scores[i]);
                }
                last = scores[i];
            }
            list.Sort();
            /*WriteArray(list);*/
            for (int i = 0; i < m; i++)
            {
                int index = list.BinarySearch(alice[i]);
                int insertIndex = 0;
                if (index < 0)
                {
                    insertIndex = list.Count - (~index) + 1;
                }
                else
                    insertIndex = list.Count - index;
                /*Console.WriteLine("alice[i]={2},index={0}, insertindex={1}", index, insertIndex, alice[i]);            */
                Console.WriteLine(insertIndex);
            }
        }
    }
}