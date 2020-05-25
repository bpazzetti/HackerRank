using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace HackerRank.Implementation
{
    class SoBetweenTwoSetslution
    {
        static int getTotalX(int[] a, int[] b)
        {
            int k = 0;
            for (int x = 1; x <= 100; x++)
            {
                bool modulo = true;
                for (int i = 0; i < a.Length; i++)
                {
                    modulo &= (x % a[i] == 0);
                }
                //Console.WriteLine("x={0}, modulo={1}",x,modulo);
                if (modulo)
                {
                    for (int i = 0; i < b.Length; i++)
                    {
                        modulo &= (b[i] % x == 0);
                    }
                    if (modulo)
                        k++;
                }
            }
            return k;
        }

        static void Main1(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int m = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            string[] b_temp = Console.ReadLine().Split(' ');
            int[] b = Array.ConvertAll(b_temp, Int32.Parse);
            int total = getTotalX(a, b);
            Console.WriteLine(total);
        }
    }
}