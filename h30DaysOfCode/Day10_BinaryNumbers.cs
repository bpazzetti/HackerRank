using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h30DaysOfCode
{
    class Day10_BinaryNumbers
    {
        public static void Main1(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string binary = string.Empty;

            for (int i = 0; n > 0; i++)
            {
                binary = (n % 2).ToString() + binary;
                n = n / 2;
            }

            int count = 0;
            int max = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1')
                {
                    count++;
                }
                else
                {
                    max = Math.Max(max, count);
                    count = 0;
                }
            }
            max = Math.Max(max, count);
            Console.WriteLine(max);

        }
    }
}
