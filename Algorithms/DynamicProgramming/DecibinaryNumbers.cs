using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Algorithms.DynamicProgramming
{
	public class DecibinaryNumbers
	{

		static long[,] dp = new long[25, 300005];
		static long[] nm = new long[300005];

		static long cnt(int d, int s)
		{
			if (d == -1 && s == 0)
				return 1;
			else if (d == -1)
				return 0;
			else if (dp[d, s] == -1)
			{
				dp[d, s] = 0;
				for (int i = 0; i <= 9 && (1 << d) * i <= s; i++)
					dp[d, s] += cnt(d - 1, s - ((1 << d) * i));
			}
			return dp[d, s];
		}

		public static void Main1(String[] args)
		{
			for (int i = 0; i < 25; i++)
				for (int j = 0; j < 300005; j++)
					dp[i, j] = -1;

			for (int i = 0; i < 300005; i++)
				nm[i] = cnt(24, i);
			for (int i = 1; i < 300005; i++)
				nm[i] += nm[i - 1];

			int q, lo, hi, ans;
			long x;
			ans = 1;
			q = Convert.ToInt32(Console.ReadLine());
			while (q-- > 0)
			{
				x = Convert.ToInt64(Console.ReadLine());
				if (x == 1)
					Console.WriteLine(0);
				else
				{
					lo = 0;
					hi = 300004;
					while (lo <= hi)
					{
						/* n / 2   <==> n * 1 >> 1  */
						/* int mid = (lo+hi)/2;    */
						int mid = (lo + hi) * 1 >> 1;
						if (nm[mid] >= x)
						{
							ans = mid;
							hi = mid - 1;
						}
						else
							lo = mid + 1;
					}

					long g = x - nm[ans - 1];
					int s = ans;
					long val;
					int d = 0;

					for (int i = -1; cnt(i, s) < g; i++)
						d = i;
					d++;

					StringBuilder builder1 = new StringBuilder();

					while (d >= 0)
					{
						val = 0;
						for (int i = 0; i <= 9; i++)
						{
							if ((s - (1 << d) * i) >= 0)
								val += cnt(d - 1, s - (1 << d) * i);
							if (val >= g)
							{
								/*Console.Write(i);*/
								builder1.Append(i);
								g -= val - cnt(d - 1, s - (1 << d) * i);
								s -= (1 << d) * i;
								break;
							}
						}
						d--;
					}
					/*Console.Write("\n");*/
					Console.WriteLine(builder1.ToString());

				}
			}
		}
	}
}