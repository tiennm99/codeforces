using System;

namespace problem_50A
{
	class problem_50A
	{
		static void Main(string[] args)
		{
			int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
			Console.WriteLine("{0}", a[0] * a[1] / 2);
		}
	}
}