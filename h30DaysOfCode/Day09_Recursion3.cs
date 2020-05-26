using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h30DaysOfCode
{
    class Day09_Recursion3
    {
        static int factorial(int n)
        {
            if (n <= 1)
                return 1;
            else
                return n * factorial(n - 1);
        }

        public static void Main1(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(factorial(n));
        }
    }
}
