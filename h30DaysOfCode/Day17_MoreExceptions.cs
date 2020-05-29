using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h30DaysOfCode
{
    class Day17_MoreExceptions
    {
        class Calculator
        {
            public int power(int n, int p)
            {
                if (n < 0 || p < 0)
                    throw new Exception("n and p should be non-negative");
                else
                {
                    return int.Parse(Math.Pow(n, p).ToString());
                }
            }
        }
        public static void Main1(String[] args)
        {
            Calculator myCalculator = new Calculator();
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                string[] num = Console.ReadLine().Split();
                int n = int.Parse(num[0]);
                int p = int.Parse(num[1]);
                try
                {
                    int ans = myCalculator.power(n, p);
                    Console.WriteLine(ans);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
