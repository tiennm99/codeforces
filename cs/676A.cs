using System;
using System.Linq;

namespace problem_676A
{
	class problem_676A
	{
		public static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			int p1 = Array.IndexOf(a, a.Min());
			int p2 = Array.IndexOf(a, a.Max());
			Console.Write("{0}", new[] { p1, p2, n - 1 - p1, n - 1 - p2 }.Max());
		}
	}
}
