using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace HackerRank.Implementation
{
    class EqualizeTheArray
    {

        static int equalizethArray(int n, int[] ar)
        {
            var iMax = ar.GroupBy(z => z).Max(group => group.Count());
            /*var order = groups.OrderBy(group => group.Count());                        */
            /*foreach(var group in order)
                Console.WriteLine("{0} -> {1}", group.Key, group.Count());
            */
            return ar.Length - iMax;
        }

        static void Main1(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = equalizethArray(n, ar);
            Console.WriteLine(result);

        }
    }
}