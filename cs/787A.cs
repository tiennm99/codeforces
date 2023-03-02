using System;

namespace _787A
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			if ((a[1] - b[1]) % GCD(a[0], b[0]) == 0)
			{
				while (a[1] != b[1])
				{
					if (a[1] < b[1])
					{
						a[1] += a[0];
					}
					else
					{
						b[1] += b[0];
					}
				}
				Console.WriteLine(a[1]);
			}
			else
			{
				Console.WriteLine(-1);
			}
		}
		static int GCD(int a, int b)
		{
			int t;
			while (b != 0)
			{
				t = a % b;
				a = b;
				b = t;
			}
			return a;
		}
	}
}
