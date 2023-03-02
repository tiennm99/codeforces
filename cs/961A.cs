using System;
using System.Linq;
using System.Collections.Generic;

namespace problem_961A
{
	class problem_961A
	{
		static void Main(string[] args)
		{
			int[] ip1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int[] ip2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int[] a = new int[ip1[0]];
			for (int i = 0; i < ip1[1]; i++)
			{
				a[ip2[i] - 1]++;
			}
			Console.Write("{0}", a.Min());
		}
	}
}