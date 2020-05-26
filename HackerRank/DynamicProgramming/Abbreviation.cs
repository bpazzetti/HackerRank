using System;
using System.Collections.Generic;
using System.IO;

namespace Algorithms.DynamicProgramming
{
	class Abbreviation
	{
		static void Main1(String[] args)
		{
			/* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
			int n = Convert.ToInt32(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				string a = Console.ReadLine();
				string b = Console.ReadLine();
				bool[,] dp = new bool[a.Length + 1, b.Length + 1];
				for (int j = 0; j < a.Length; ++j)
				{
					dp[j, 0] = true;
				}

				for (int k = 1; k <= a.Length; ++k)
				{
					for (int j = 1; j <= b.Length && j <= k; ++j)
					{
						if (Char.IsLower(a[k - 1]))
						{
							dp[k, j] = dp[k - 1, j] || (Char.ToUpper(a[k - 1]) == b[j - 1] && dp[k - 1, j - 1]);
						}
						else
						{
							dp[k, j] = a[k - 1] == b[j - 1] && dp[k - 1, j - 1];
						}
					}
				}

				Console.WriteLine(dp[a.Length, b.Length] == true ? "YES" : "NO");
			}
		}
	}
}