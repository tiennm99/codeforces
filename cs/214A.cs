using System;

namespace _214A
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			int i = 0, j = a[0], count = 0;
			while (i <= a[0] && j >= 0)
			{
				if (i + j * j == a[1])
				{
					count++;
				}
				i++;
				j = a[0] - i * i;
			}
			Console.WriteLine(count);
		}
	}
}
