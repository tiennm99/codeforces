using System;

namespace _466A
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			int b = a[0] * a[2];
			int c = (a[0] % a[1] == 0) ? a[0] / a[1] * a[3] : (a[0] / a[1] + 1) * a[3];
			int d = a[0] / a[1] * a[3] + (a[0] % a[1]) * a[2];
			Console.WriteLine(Math.Min(b, Math.Min(c, d)));
		}
	}
}
