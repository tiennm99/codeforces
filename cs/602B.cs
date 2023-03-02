using System;
using System.Linq;

namespace _602B
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			int[] b = a.ToArray();
			int[] c = a.ToArray();
			int c1 = 1, c2 = 1, max = 1;
			for (int i = 0; i < n; i++)
			{
				if (a[i] % 2 == 1)
				{
					b[i]++;
				}
				else
				{
					c[i]++;
				}
			}
			for (int i = 1; i < n; i++)
			{
				if (b[i] == b[i - 1])
				{
					c1++;
				}
				else
				{
					max = Math.Max(max, c1);
					c1 = 1;
				}
				if (c[i] == c[i - 1])
				{
					c2++;
				}
				else
				{
					max = Math.Max(max, c2);
					c2 = 1;
				}
			}
			max = Math.Max(Math.Max(c1, c2), max);
			Console.WriteLine(max);
		}
	}
}
