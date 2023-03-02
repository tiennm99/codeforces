using System;

namespace problem_430A
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] ip = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			int max = 0;
			for (int i = 1; i < ip[0]; i++)
			{
				if (a[i] != ip[2] || a[i - 1] != ip[2])
				{
					continue;
				}
				int l = i - 2, r = i + 1, cur = 2;
				while (l >= 0 && r < ip[0])
				{
					int tmp = a[r];
					int t = 0;
					while (l >= 0 && a[l] == tmp)
					{
						l--;
						t++;
					}
					while (r < ip[0] && a[r] == tmp)
					{
						r++;
						t++;
					}
					if (t < 3)
					{
						break;
					}
					else
					{
						cur += t;
					}
				}
				if (cur > max)
				{
					max = cur;
				}
			}
			Console.Write(max);
		}
	}
}
