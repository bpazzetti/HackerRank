using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Algorithms.BitManipulation
{
	public class SumVsXOR
	{
		public static double solve(long n)
		{
			int unset_bits = 0;
			while (n > 0)
			{
				if ((n & 1) == 0)
					unset_bits++;
				n = n >> 1;
			}
			return (Math.Pow(2, unset_bits));
		}

		public static void Main1(String[] args)
		{
			long n = Convert.ToInt64(Console.ReadLine());
			double result = solve(n);
			Console.WriteLine(result);
		}
	}
}