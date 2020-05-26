using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h30DaysOfCode
{
    class Day11_2DArrays
    {
        public static void Main1(string[] args)
        {
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int max = int.MinValue;
            for (int i = 0; i < 4; i++)
            {                
                for (int j = 0; j < 4; j++)
                {
                    int sum = 0;
                    sum += arr[i][j];
                    sum += arr[i][j+1];
                    sum += arr[i][j+2];
                    sum += arr[i+1][j+1];
                    sum += arr[i+2][j];
                    sum += arr[i+2][j+1];
                    sum += arr[i+2][j+2];
                    max = Math.Max(max, sum);
                }
            }
            Console.WriteLine(max);

        }
    }
}
