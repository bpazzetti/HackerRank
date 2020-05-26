using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Implementation
{
	//@Algorithms. Can you complete the challenge? http://hr.gs/3ru4 #programming
	static class FormingAMagicSquare
	{
		static int formingMagicSquare(int[][] s)
		{
			string linear = string.Empty;
			for (int i = 0; i < 3; i++)
				for (int j = 0; j < 3; j++)
					linear += s[i][j];

			List<string> list = new List<string>();
			permute("123456789", 0, linear.Length - 1, list);
			int min = 99999;
			foreach (var perm in list)
			{
				int[][] a = Transform(perm);
				if (isMagicSqueare(a))
				{
					int res = diff(s, a);
					if (res < min)
						min = res;
				}
			}
			return min;
		}

		static int diff(int[][] a, int[][] b)
		{
			int res = 0;
			for (int i = 0; i < 3; ++i)
				for (int j = 0; j < 3; ++j)
					res += Math.Abs(a[i][j] - b[i][j]);
			return res;
		}
		static bool isMagicSqueare(int[][] s)
		{
			int res = s[0][0] + s[0][1] + s[0][2];
			if (res != s[1][0] + s[1][1] + s[1][2])
				return false;
			if (res != s[2][0] + s[2][1] + s[2][2])
				return false;
			if (res != s[0][0] + s[1][0] + s[2][0])
				return false;
			if (res != s[0][1] + s[1][1] + s[2][1])
				return false;
			if (res != s[0][2] + s[1][2] + s[2][2])
				return false;
			if (res != s[0][0] + s[1][1] + s[2][2])
				return false;
			if (res != s[2][0] + s[1][1] + s[0][2])
				return false;
			return true;
		}

		static int[][] Transform(string s)
		{
			int[][] a = new int[3][];
			for (int i = 0; i < 3; i++)
			{
				a[i] = new int[3];
				for (int j = 0; j < 3; j++)
					a[i][j] = int.Parse(s[3 * i + j].ToString());
			}
			return a;
		}

		static void permute(String str, int l, int r, List<string> list)
		{
			if (l == r)
			{
				//Console.WriteLine(str);
				list.Add(str);
			}
			else
			{
				for (int i = l; i <= r; i++)
				{
					str = swap(str, l, i);
					permute(str, l + 1, r, list);
					str = swap(str, l, i);
				}
			}
		}

		static String swap(String a,
							  int i, int j)
		{
			char temp;
			char[] charArray = a.ToCharArray();
			temp = charArray[i];
			charArray[i] = charArray[j];
			charArray[j] = temp;
			string s = new string(charArray);
			return s;
		}

		static void Mn(string[] args)
		{
			int[][] s = new int[3][];

			for (int i = 0; i < 3; i++)
			{
				s[i] = Array.ConvertAll(Console.ReadLine().Split(' '), sTemp => Convert.ToInt32(sTemp));
			}

			int result = formingMagicSquare(s);

			Console.WriteLine(result);
		}
	}	
}
