using System;

namespace problem_158B
{
	class problem_158B
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[] a = new int[4];
			int[] ip = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			for (int i = 0; i < n; i++)
			{
				a[ip[i] - 1]++;
			}
			int c = a[3];
			c += a[2];
			a[0] -= a[2];
            if (a[0] < 0)
			{
				a[0] = 0;
			}
			c += a[1] / 2;
			a[1] %= 2;
			a[0] += 2 * a[1];
			c += a[0] / 4;
			if (a[0] % 4 != 0)
			{
				c++;
			}
			Console.Write(c);
		}
	}
}