﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
	class Program
	{
		static int M = 26;
		static void Main(string[] args)
		{
			Console.WriteLine(isValid("abcdefghhgfedecba"));
		}

		static string isValid(string s)
		{

			int l = s.Length;
			int[] freq = new int[M];
			for (int i = 0; i < s.Length; i++)
			{
				freq[s[i] - 'a']++;
			}

			var same = freq.First(o => o != 0);

			var res = freq.All(a => a == same);


			return res ? "YES": "NO";
		}
	}
}
