using System;

namespace problem_224B
{
	class problem_224B
	{
		public static void Main(string[] args)
		{
			int[] ip = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			int count = 0;
			int[] c = new int[100000];
			for (int i = 0; i < ip[0]; i++)
			{
				if (c[a[i] - 1]++ == 0)
				{
					count++;
				}
			}
			if (count < ip[1])
			{
				Console.Write("-1 -1");
			}
			else
			{
				int i;
				for (i = ip[0] - 1; count >= ip[1]; i--)
				{
					if (--c[a[i] - 1] == 0)
					{
						count--;
					}
				}
				int r = ++i;
				c[a[i] - 1]++;
				count++;
				for (i = 0; count == ip[1]; i++)
				{
					c[a[i] - 1]--;
					if (c[a[i] - 1] == 0) count--;
				}
				int l = --i;
				c[a[i] - 1]++;
				count++;
				Console.Write("{0} {1}", l + 1, r + 1);
			}
		}
	}
}
