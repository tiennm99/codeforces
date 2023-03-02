using System;

namespace problem_673A
{
	class problem_673A
	{
		public static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			int l = 15;
			for (int i = 0; i < n; i++)
			{
				if (a[i] <= l)
				{
					l = a[i] + 15;
				}
				else
				{
					break;
				}
			}
			l = Math.Min(l, 90);
			Console.Write(l);
		}
	}
}
