using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace Algorithms.Strings
{
	public class BuildAPalindrome
	{
		public static int[] BuildSuffixArray(string s)
		{
			int n = s.Length;
			var cnt = new int[128];
			for (int i = 0; i < n; ++i)
				++cnt[s[i]];
			for (int i = 1; i < 128; ++i)
				cnt[i] += cnt[i - 1];

			var p = new int[n];
			for (int i = 0; i < n; ++i)
				p[--cnt[s[i]]] = i;

			var c = new int[n];
			int classes = 1;
			for (int i = 1; i < n; ++i)
			{
				if (s[p[i]] != s[p[i - 1]])
					++classes;
				c[p[i]] = classes - 1;
			}

			var pn = new int[n];
			for (int h = 0; 1 << h < n; ++h)
			{
				var cn = new int[n];
				for (int i = 0; i < n; ++i)
				{
					pn[i] = p[i] - (1 << h);
					if (pn[i] < 0)
						pn[i] += n;
				}
				cnt = new int[classes];
				for (int i = 0; i < n; ++i)
					++cnt[c[pn[i]]];
				for (int i = 1; i < classes; ++i)
					cnt[i] += cnt[i - 1];
				for (int i = n - 1; i >= 0; --i)
					p[--cnt[c[pn[i]]]] = pn[i];
				cn[p[0]] = 0;
				classes = 1;
				for (int i = 1; i < n; ++i)
				{
					int mid1 = (p[i] + (1 << h)) % n;
					int mid2 = (p[i - 1] + (1 << h)) % n;
					if (c[p[i]] != c[p[i - 1]] || c[mid1] != c[mid2])
						++classes;
					cn[p[i]] = classes - 1;
				}
				c = cn;
			}

			return p;
		}

		public static int[] BuildLcp(string s, int[] p)
		{
			int n = s.Length;

			var rank = new int[n];
			for (int i = 0; i < n; ++i)
				rank[p[i]] = i;

			var lcp = new int[n];
			for (int i = 0, k = 0; i < n; ++i)
			{
				if (k > 0)
					k--;
				if (rank[i] == n - 1)
				{
					lcp[n - 1] = -1;
					k = 0;
					continue;
				}
				int j = p[rank[i] + 1];
				while (Math.Max(i + k, j + k) < n && s[i + k] == s[j + k])
					k++;
				lcp[rank[i]] = k;
			}

			return lcp;
		}


		public static bool isPalindrome(string s)
		{
			int length = s.Length;
			for (int i = 0; i < length / 2; i++)
			{
				if (s[i] != s[length - i - 1])
					return false;
			}

			return true;
		}

		public static void getSubstrings(string s, HashSet<string> substrings)
		{
			for (int i = 0; i < s.Length; i++)
			{
				for (int j = i; j < s.Length; j++)
					substrings.Add(s.Substring(i, j - i + 1));
			}
		}

		public static void Main1(String[] args)
		{
			/*
			int n;
			string sFirst;
			string sSecond;
			HashSet<string> hsFirstSubStrings;
			HashSet<string> hsSecondSubStrings;
			n = Convert.ToInt32(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				sFirst = Console.ReadLine();
				sSecond = Console.ReadLine();
				hsFirstSubStrings = new HashSet<string>();
				hsSecondSubStrings = new HashSet<string>();
				getSubstrings(sFirst, hsFirstSubStrings);
				getSubstrings(sSecond, hsSecondSubStrings);
				int maxLength = 0;
				string maxPal = string.Empty;			
				foreach (string s1 in hsFirstSubStrings)
				{
					foreach (string s2 in hsSecondSubStrings)
					{
						string s3 = string.Concat(s1, s2);
						if (isPalindrome(s3) && maxLength <= s3.Length)
						{
							if (string.IsNullOrEmpty(maxPal) || (maxLength == s3.Length && String.Compare(maxPal, s3) > 0) || maxLength < s3.Length)
							{
								maxPal = s3;
								maxLength = s3.Length;
							}
						}
					}

				}

				Console.WriteLine(maxLength == 0 ? "-1" : maxPal);
			}*/
			for (int tt = ReadInt(); tt > 0; tt--)
			{
				string sFirst = ReadToken();
				string sSecond = ReadToken();

				int fLength = sFirst.Length;
				int sLength = sSecond.Length;
				var arrFirst = new int[26];
				var arrSecond = new int[26];
				/*Count characters if they have one in common, a palindrome exists*/
				for (int i = 0; i < fLength; i++)
				{
					arrFirst[sFirst[i] - 'a']++;
				}
				for (int i = 0; i < sLength; i++)
				{
					arrSecond[sSecond[i] - 'a']++;
				}
				bool ok = false;
				for (int i = 0; i < 26; i++)
					if (arrFirst[i] > 0 && arrSecond[i] > 0)
						ok = true;
				if (!ok)
				{
					Write(-1);
					continue;
				}
				/*Palindrome exists*/
				string rFstring = new string(sFirst.Reverse().ToArray());
				string sString = rFstring + sSecond + "#";
				var suffixArray = BuildSuffixArray(sString);
				WriteArray(suffixArray);
				var rsa = new int[fLength + sLength];
				for (int i = 0; i < fLength + sLength; i++)
					rsa[suffixArray[i + 1]] = i + 1;
				var lcp = BuildLcp(sString, suffixArray);


				WriteArray(rsa);
				WriteArray(sString);
				WriteArray(lcp);


				var dp = new int[fLength + sLength + 1];
				var dpx = new int[fLength + sLength + 1];
				int p = fLength + sLength - 1;
				while (suffixArray[p] >= fLength == suffixArray[p + 1] >= fLength)
					p--;
				int v = lcp[p], z = p + 1;
				while (p > 0)
				{
					if (suffixArray[p] >= fLength != suffixArray[p + 1] >= fLength)
					{
						v = lcp[p];
						z = p + 1;
						if (v > dp[z])
						{
							dp[z] = v;
							dpx[z] = suffixArray[p];
						}
					}
					v = Math.Min(v, lcp[p]);
					dp[p] = v;
					dpx[p] = suffixArray[z];
					p--;
				}

				var spo = new int[fLength];
				int l = 0, r = -1;
				for (int i = 0; i < fLength; ++i)
				{
					int k = i > r ? 1 : Math.Min(spo[l + r - i], r - i);
					while (i + k < fLength && i - k >= 0 && sFirst[i + k] == sFirst[i - k])
						++k;
					spo[i] = k;
					if (i + k > r)
					{
						l = i - k + 1;
						r = i + k - 1;
					}
				}

				var spe = new int[fLength];
				l = 0;
				r = -1;
				for (int i = 0; i < fLength; i++)
				{
					int k = i > r ? 0 : Math.Min(spe[l + r - i + 1], r - i + 1);

					while (i + k < fLength && i - k - 1 >= 0 && sFirst[i + k] == sFirst[i - k - 1]) k++;
					spe[i] = k;

					if (i + k - 1 > r)
					{
						l = i - k;
						r = i + k - 1;
					}
				}

				var tpo = new int[sLength];
				l = 0;
				r = -1;
				for (int i = 0; i < sLength; ++i)
				{
					int k = i > r ? 1 : Math.Min(tpo[l + r - i], r - i);
					while (i + k < sLength && i - k >= 0 && sSecond[i + k] == sSecond[i - k])
						++k;
					tpo[i] = k;
					if (i + k > r)
					{
						l = i - k + 1;
						r = i + k - 1;
					}
				}

				var tpe = new int[sLength];
				l = 0;
				r = -1;
				for (int i = 0; i < sLength; i++)
				{
					int k = i > r ? 0 : Math.Min(tpe[l + r - i + 1], r - i + 1);

					while (i + k < sLength && i - k - 1 >= 0 && sSecond[i + k] == sSecond[i - k - 1]) k++;
					tpe[i] = k;

					if (i + k - 1 > r)
					{
						l = i - k;
						r = i + k - 1;
					}
				}

				int best = 0;
				var o = new List<Tuple<int, int, int, int>>();
				for (int i = 0; i < fLength; i++)
				{
					p = i - spo[i];
					int len = spo[i] * 2 - 1;
					int sym = 0;
					if (p >= 0)
						sym = dp[rsa[fLength - p - 1]];
					if (sym > 0 && len + 2 * sym > best)
					{
						best = len + 2 * sym;
						o.Clear();
						o.Add(Tuple.Create(p - sym + 1, p + len, dpx[rsa[fLength - p - 1]] - fLength, dpx[rsa[fLength - p - 1]] - fLength + sym - 1));
					}
					else if (sym > 0 && len + 2 * sym == best)
						o.Add(Tuple.Create(p - sym + 1, p + len, dpx[rsa[fLength - p - 1]] - fLength, dpx[rsa[fLength - p - 1]] - fLength + sym - 1));

					p = spe[i] > 0 ? i - spe[i] - 1 : i;
					len = spe[i] * 2;
					sym = 0;
					if (p >= 0)
						sym = dp[rsa[fLength - p - 1]];
					if (sym > 0 && len + 2 * sym > best)
					{
						best = len + 2 * sym;
						o.Clear();
						o.Add(Tuple.Create(p - sym + 1, p + len, dpx[rsa[fLength - p - 1]] - fLength, dpx[rsa[fLength - p - 1]] - fLength + sym - 1));
					}
					else if (sym > 0 && len + 2 * sym == best)
						o.Add(Tuple.Create(p - sym + 1, p + len, dpx[rsa[fLength - p - 1]] - fLength, dpx[rsa[fLength - p - 1]] - fLength + sym - 1));
				}

				for (int i = 0; i < sLength; i++)
				{
					p = i + tpo[i];
					int len = tpo[i] * 2 - 1;
					int sym = 0;
					if (p < sLength)
						sym = dp[rsa[fLength + p]];
					if (sym > 0 && len + 2 * sym > best)
					{
						best = len + 2 * sym;
						o.Clear();
						o.Add(Tuple.Create(fLength - dpx[rsa[fLength + p]] - sym, fLength - dpx[rsa[fLength + p]] - 1, i - tpo[i] + 1, p + sym - 1));
					}
					else if (sym > 0 && len + 2 * sym == best)
						o.Add(Tuple.Create(fLength - dpx[rsa[fLength + p]] - sym, fLength - dpx[rsa[fLength + p]] - 1, i - tpo[i] + 1, p + sym - 1));

					p = tpe[i] > 0 ? i + tpe[i] : i;
					len = tpe[i] * 2;
					sym = 0;
					if (p < sLength)
						sym = dp[rsa[fLength + p]];
					if (sym > 0 && len + 2 * sym > best)
					{
						best = len + 2 * sym;
						o.Clear();
						o.Add(Tuple.Create(fLength - dpx[rsa[fLength + p]] - sym, fLength - dpx[rsa[fLength + p]] - 1, i - tpe[i], p + sym - 1));
					}
					else if (sym > 0 && len + 2 * sym == best)
						o.Add(Tuple.Create(fLength - dpx[rsa[fLength + p]] - sym, fLength - dpx[rsa[fLength + p]] - 1, i - tpe[i], p + sym - 1));
				}

				string ans = "";
				foreach (var op in o)
				{
					string w = sFirst.Substring(op.Item1, op.Item2 - op.Item1 + 1) + sSecond.Substring(op.Item3, op.Item4 - op.Item3 + 1);
					if (ans == "" || string.Compare(w, ans) < 0)
						ans = w;
				}
				//Write(best, sbestl, sbestr, tbestl, tbestr);
				Write(ans);
			}
		}

		public static string ReadToken() { return Console.ReadLine(); }
		public static int ReadInt() { return int.Parse(ReadToken()); }
		public static void WriteArray<T>(IEnumerable<T> array) { Console.WriteLine(string.Join(" ", array)); }
		public static void Write(params object[] array) { WriteArray(array); }
		public static void WriteLines<T>(IEnumerable<T> array) { foreach (var a in array) Console.WriteLine(a); }
	}
}