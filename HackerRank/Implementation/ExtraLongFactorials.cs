using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Implementation
{
    class ExtraLongFactorials
    {
        static void extraLongFactorials(int n)
        {
            Console.WriteLine(factorial(n));
        }

        static BigInteger factorial(int number)
        {
            BigInteger result = 1;
            while (number != 1)
            {
                result = result * number;
                number = number - 1;
            }
            return result;
        }

        public static void Main1(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            extraLongFactorials(n);
        }
    }
}
