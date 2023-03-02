using System;

namespace _492A
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int a = 0, b = 0, c = 0;
			while (n > c)
			{
				a++;
				b = a * (a + 1) / 2;
				c += b;
			}
			Console.WriteLine(c > n ? a - 1 : a);
		}
	}
}
