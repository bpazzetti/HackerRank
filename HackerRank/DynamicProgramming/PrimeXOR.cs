using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Algorithms.DynamicProgramming
{
	public class PrimeXOR
	{
		public static void Main1(String[] args)
		{
			/* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
			bool[] primes;

			const int LIMIT = 9000;
			const int MAX = 8192;
			const int PRIMES = 9025;
			const int mod = 1000000007;
			long[,] mem = new long[2, MAX];
			int[] a;
			List<int> v;

			primes = Enumerable.Repeat(true, PRIMES).ToArray();
			primes[0] = false;
			primes[1] = false;

			for (int i = 4; i <= LIMIT; i += 2)
				primes[i] = false;

			for (int i = 3; i * i < LIMIT; i += 2)
			{
				if (primes[i] == true)
				{
					for (int j = i * i; j <= LIMIT; j += 2 * i)
						primes[j] = false;
				}
			}

			int bufSize = 1024;
			Stream inStream = Console.OpenStandardInput(bufSize);
			Console.SetIn(new StreamReader(inStream, Console.InputEncoding, false, bufSize));
			int q = Convert.ToInt32(Console.ReadLine());

			while (q-- > 0)
			{
				int n = Convert.ToInt32(Console.ReadLine());
				string[] arr_temp = Console.ReadLine().Split(' ');
				int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
				v = new List<int>();
				a = new int[5025];
				mem = new long[2, MAX];
				mem[0, 0] = 1;

				for (int i = 0; i < n; i++)
				{
					a[arr[i]] += 1;
				}

				for (int i = 3500; i < 4525; i++)
					if (a[i] >= 1)
						v.Add(i);

				int flag = 1;
				int k = v.Count();
				for (int i = 1; i <= k; i++)
				{
					for (int j = 0; j < 8192; j++)
					{
						mem[flag, j] = (mem[flag ^ 1, j] * (1 + (a[v[i - 1]]) / 2)) % mod + (mem[flag ^ 1, j ^ v[i - 1]] * ((a[v[i - 1]] + 1) / 2)) % mod;
						if (mem[flag, j] >= mod)
							mem[flag, j] %= mod;
					}
					flag = flag ^ 1;
				}

				long res = 0;
				for (int i = 1; i < 8192; i++)
				{
					if (primes[i])
					{
						res += mem[flag ^ 1, i];
						res %= mod;
					}
				}
				Console.WriteLine(res);
			}
		}
	}
}