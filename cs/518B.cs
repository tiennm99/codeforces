using System;

namespace _518B
{
	class Program
	{
		static void Main(string[] args)
		{
			string s = Console.ReadLine();
			string t = Console.ReadLine();
			int[] c1 = new int[52];
			int[] c2 = new int[52];
			for (int i = 0; i < s.Length; i++)
			{
				if (char.IsLower(s[i]))
				{
					c1[s[i] - 'a']++;
				}
				else
				{
					c1[s[i] - 'A' + 26]++;
				}
			}
			for (int i = 0; i < t.Length; i++)
			{
				if (char.IsLower(t[i]))
				{
					c2[t[i] - 'a']++;
				}
				else
				{
					c2[t[i] - 'A' + 26]++;
				}
			}
			int y = 0, w = 0;
			for (int i = 0; i < 26; i++)
			{
				y += Math.Min(c1[i], c2[i]) + Math.Min(c1[i + 26], c2[i + 26]);
				w += Math.Min(Math.Max(c1[i] - c2[i], 0), Math.Max(c2[i + 26] - c1[i + 26], 0)) + Math.Min(Math.Max(c1[i + 26] - c2[i + 26], 0), Math.Max(c2[i] - c1[i], 0));
			}
			Console.WriteLine("{0} {1}", y, w);
		}
	}
}
