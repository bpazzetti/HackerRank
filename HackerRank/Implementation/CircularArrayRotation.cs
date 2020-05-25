using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Implementation
{
    class CircularArrayRotation
    {
        static int[] circularArrayRotation(int[] a, int k, int[] queries)
        {
            int n = a.Length;
            int[] res = new int[queries.Length];

            for (int i = 0; i < queries.Length; i++)
            {
                int index = (n - (k % n) + queries[i]) % n;
                res[i] = a[index];
            }
            return res;
        }
        static void Main1(string[] args)
        {
            string[] nkq = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nkq[0]);

            int k = Convert.ToInt32(nkq[1]);

            int q = Convert.ToInt32(nkq[2]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;

            int[] queries = new int[q];

            for (int i = 0; i < q; i++)
            {
                int queriesItem = Convert.ToInt32(Console.ReadLine());
                queries[i] = queriesItem;
            }

            int[] result = circularArrayRotation(a, k, queries);

            Console.WriteLine(string.Join("\n", result));

            Console.ReadLine();
        }
    }
}
