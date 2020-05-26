using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Algorithms.Warmup
{
    class N09_BirthdayCakeCandles
    {

        static int birthdayCakeCandles(int n, int[] arr)
        {
            // Complete this function
            int max = 0;
            for (int i = 0; i < n; i++)
                if (arr[i] > max)
                    max = arr[i];
            int count = 0;
            for (int i = 0; i < n; i++)
                if (arr[i] == max)
                    count++;
            return count;
        }

        static void Main1(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = birthdayCakeCandles(n, ar);
            Console.WriteLine(result);
        }
    }
}