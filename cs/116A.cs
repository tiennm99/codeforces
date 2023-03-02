using System;

namespace _116A
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int max = 0, cur = 0;
			for (int i = 0; i < n; i++)
			{
				int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
				cur = cur - a[0] + a[1];
				if (cur > max)
				{
					max = cur;
				}
			}
			Console.WriteLine(max);
		}
	}
}
