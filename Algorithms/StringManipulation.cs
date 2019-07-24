using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
	public class StringManipulation
	{
		static int M = 26;
		public string isValid(string s)
		{
			var res = false;
			int l = s.Length;
			int[] freq = new int[M];

			for (int o = 0; o < s.Length; o++)
				freq[getIndex(s[o])]++;


			res = allSame(freq, M);

			if (!res)
			{
				for (char c = 'a'; c <= 'z'; c++)
				{
					var index = getIndex(c);

					if (freq[index] > 0)
					{
						freq[index]--;

						if (allSame(freq, M))
							res = true;
						freq[index]++;
					}
				}
			}

			return res ? "YES" : "NO";
		}

		public int getIndex(char c)
		{
			return c - 'a';
		}

		public bool allSame(int[] freq, int l)
		{
			var same = 0;
			int i;
			for (i = 0; i < l; i++)
			{
				if (freq[i] > 0)
				{
					same = freq[i];
					break;
				}
			}

			for (int j = i + 1; j < M; j++)
			{
				if (freq[j] > 0 && freq[j] != same)
				{
					return false;

				}
			}
			return true;
		}
	}
}
