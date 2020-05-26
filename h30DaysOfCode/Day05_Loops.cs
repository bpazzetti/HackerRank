using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h30DaysOfCode
{
    class Day05_Loops
    {
        public static void Main1(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
                Console.WriteLine("{0} x {1} = {2}", n, i, i * n);
        }
    }
}
