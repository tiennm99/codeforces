using System;

namespace problem_1006A
{
	class problem_1006A
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			for (int i = 0; i < n; i++)
			{
				if (a[i] % 2 == 0)
				{
					a[i]--;
				}
			}
			foreach (int t in a)
			{
				Console.Write("{0} ", t);
			}
		}
	}
}
