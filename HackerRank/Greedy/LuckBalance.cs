using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace HackerRank.Greedy
{
    class LuckBalance
    {
        static void Main1(String[] args)
        {
            var temp = Console.ReadLine().Split(' ');
            var arr = Array.ConvertAll(temp, Int32.Parse);
            var N = arr[0];
            var K = arr[1];

            List<Tuple<int, int>> luckBalance = new List<Tuple<int, int>>();
            for (var contest = 0; contest < N; contest++)
            {
                var ln_temp = Console.ReadLine().Split(' ');
                var ln = Array.ConvertAll(ln_temp, Int32.Parse);
                var luck = ln[0];
                var importance = ln[1];
                luckBalance.Add(Tuple.Create(luck, importance));
            }
            var importanContests = luckBalance.Where(u => u.Item2 == 1).Select(u => u.Item1).OrderBy(u => u).ToList();
            var luckSum = luckBalance.Select(u => u.Item1).Sum();
            int luckToFlip = 0;
            int mustWinImprCount = importanContests.Count() - K;
            for (int i = 0; i < mustWinImprCount; i++)
            {
                luckToFlip += importanContests[i];
            }
            int result = luckSum - 2 * luckToFlip;
            Console.Write(result);
        }
    }
}