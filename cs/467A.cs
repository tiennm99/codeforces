using System;

namespace _467A
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int count = 0;
			for (int i = 0; i < n; i++)
			{
				int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
				if (a[1] - a[0] > 1)
				{
					count++;
				}
			}
			Console.WriteLine(count);
		}
	}
}
