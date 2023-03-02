using System;

namespace _546A
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			Console.WriteLine("{0}", Math.Max(a[0] * a[2] * (a[2] + 1) / 2 - a[1], 0));
		}
	}
}
