using System;

namespace _217A
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[] p = new int[n];
			int[][] a = new int[n][];
			int c = 0;
			for (int i = 0; i < n; i++)
			{
				a[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
				p[i] = i;
			}
			for (int i = 0; i < n - 1; i++)
			{
				for (int j = i + 1; j < n; j++)
				{
					if (a[i][0] == a[j][0] || a[i][1] == a[j][1])
					{
						int ti = p[i];
						while (ti != p[ti])
						{
							ti = p[ti];
						}
						int tj = p[j];
						while (tj != p[tj])
						{
							tj = p[tj];
						}
						p[tj] = ti;
					}
				}
			}
			for (int i = 0; i < n; i++)
			{
				if (i == p[i])
				{
					c++;
				}
			}
			Console.WriteLine(c - 1);
		}
	}
}
