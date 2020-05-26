using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Algorithms.Implementation
{
    class MigratoryBirds
    {

        static int migratoryBirds(int n, int[] ar)
        {
            var groups = ar.GroupBy(z => z);
            var order = groups.OrderBy(group => group.Count()).ThenByDescending(k => k.Key);
            /*foreach(var group in order)
                Console.WriteLine("{0} -> {1}", group.Key, group.Count());
            */
            return order.Last().Key;
        }

        static void Main1(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = migratoryBirds(n, ar);
            Console.WriteLine(result);
        }
    }
}