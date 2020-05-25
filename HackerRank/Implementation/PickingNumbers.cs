using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace HackerRank.Implementation
{
    class PickingNumbers
    {

        public static void WriteArray<T>(IEnumerable<T> array) { Console.WriteLine(string.Join(" ", array)); }

        static void Main1(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            int[] b = new int[100];
            int max = 0;
            for (int i = 0; i < n; i++)
                b[a[i]]++;
            for (int i = 0; i < 99; i++)
                if (b[i] + b[i + 1] > max)
                    max = b[i] + b[i + 1];
            //WriteArray(a);
            //WriteArray(b);
            Console.WriteLine(max);




        }
    }
}