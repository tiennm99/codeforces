using System;

namespace _499B
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			bool[] b = new bool[a[1]];
			string[] s1 = new string[a[1]];
			string[] s2 = new string[a[1]];
			for (int i = 0; i < a[1]; i++)
			{
				string[] ip = Console.ReadLine().Split(' ');
				s1[i] = ip[0];
				s2[i] = ip[1];
				if (s2[i].Length < s1[i].Length)
				{
					b[i] = true;
				}
			}
			string[] s = Console.ReadLine().Split(' ');
			for (int i = 0; i < a[0]; i++)
			{
				int p = Array.IndexOf(s1, s[i]);
				if (b[p])
				{
					s[i] = s2[p];
				}
			}
			foreach (string t in s)
			{
				Console.Write("{0} ", t);
			}
		}
	}
}
