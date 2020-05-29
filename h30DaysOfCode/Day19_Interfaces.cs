using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h30DaysOfCode
{
    class Day19_Interfaces
    {
        public interface AdvancedArithmetic
        {
            int divisorSum(int n);
        }
        public class Calculator : AdvancedArithmetic
        {
            public int divisorSum(int n)
            {
                int sum = 0;
                for (int i = 1; i <= n; i++)
                    if (n % i == 0)
                        sum += i;
                return sum;
            }
        }

        public static void Main1(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            AdvancedArithmetic myCalculator = new Calculator();
            int sum = myCalculator.divisorSum(n);
            Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
        }
    }
}
