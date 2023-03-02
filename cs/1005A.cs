using System;
using System.Collections;

namespace problem_1005A
{
	class problem_1005A
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			ArrayList b = new ArrayList();
			for (int i = 0; i < n - 1; i++)
			{
				if (a[i + 1] == 1)
				{
					b.Add(a[i]);
				}
			}
			b.Add(a[n - 1]);
			Console.WriteLine(b.Count);
            foreach (var t in b)
			{
				Console.Write("{0} ", t);
			}
		}
	}
}