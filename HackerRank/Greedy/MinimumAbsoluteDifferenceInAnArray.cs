using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace HackerRank.Greedy
{
    class MinimumAbsoluteDifferenceInAnArray
    {

        public static void WriteLines<T>(IEnumerable<T> array)
        {
            foreach (var a in array)
                Console.WriteLine(a);
        }

        static void Main1(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            Array.Sort(a);
            int min = a[1] - a[0];
            int res = 0;
            /*WriteLines(a);               */
            for (int i = 0; i < n - 1; i++)
            {
                res = Math.Abs(a[i + 1] - a[i]);
                /*Console.WriteLine("a[{0}]={1}, a[{2}]={3}, res={4}, min={5}",i,a[i], i+1, a[i+1],res,min);*/
                if (res < min)
                    min = res;
            }
            Console.WriteLine(min);
        }
    }
}