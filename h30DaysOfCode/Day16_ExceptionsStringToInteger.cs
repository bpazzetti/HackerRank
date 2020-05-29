using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h30DaysOfCode
{
    class Day16_ExceptionsStringToInteger
    {
        public static void Main1(String[] args)
        {
            string S = Console.ReadLine();
            int N;
            try
            {
                N = int.Parse(S);
                Console.WriteLine($"{N}");
            }
            catch (Exception)
            {
                Console.WriteLine("Bad String");
            }
        }
    }
}
