using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Algorithms.Greedy
{
    class MarcsCakewalk
    {

        static void Main1(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] calories_temp = Console.ReadLine().Split(' ');
            int[] calories = Array.ConvertAll(calories_temp, Int32.Parse);
            Array.Sort<int>(calories,
                    delegate (int a, int b)
                    {
                        return b - a; //Normal compare is a-b
                });
            double miles = 0;
            for (int i = 0; i < n; i++)
            {
                miles += (Math.Pow(2, i) * calories[i]);
            }
            Console.WriteLine(miles);
        }
    }
}