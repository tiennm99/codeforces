using System;
using System.Linq;

namespace problem_242B
{
	class problem_242B
	{
		public static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[] a = new int[n];
			int[] b = new int[n];
			for (int i = 0; i < n; i++)
			{
				string[] ip = Console.ReadLine().Split(' ');
				a[i] = int.Parse(ip[0]);
				b[i] = int.Parse(ip[1]);
			}
			int m1 = a.Min();
			int m2 = b.Max();
			int c = -1;
			for (int i = 0; i < n; i++)
			{
				if (a[i] == m1 && b[i] == m2)
				{
					c = i + 1;
					break;
				}
			}
			Console.Write(c);
		}
	}
}
