using System;

namespace _721B
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			int[] l = new int[a[0]];
			for (int i = 0; i < a[0]; i++)
			{
				l[i] = Console.ReadLine().Length;
			}
			int lp = Console.ReadLine().Length;
			Array.Sort(l);
			int p1 = Array.IndexOf(l, lp);
			int p2 = Array.LastIndexOf(l, lp);
			Console.Write("{0} {1}", p1 / a[1] * 5 + p1 + 1, p2 / a[1] * 5 + p2 + 1);
		}
	}
}
