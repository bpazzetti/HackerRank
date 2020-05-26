using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Algorithms.Implementation
{
    class SockMerchant
    {

        static int sockMerchant(int n, int[] ar)
        {
            var groups = ar.GroupBy(z => z);
            int total = 0;
            foreach (var group in groups)
                total += group.Count() / 2;
            return total;
        }

        static void Main1(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = sockMerchant(n, ar);
            Console.WriteLine(result);
        }
    }
}