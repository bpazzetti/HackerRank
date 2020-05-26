using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h30DaysOfCode
{
    class Day07_Arrays
    {
        public static void Main1(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            string s = "";
            for (int i = 0; i < n; i++)
                s = arr[i].ToString() + " " + s;
            Console.WriteLine(s);
        }
    }
}
