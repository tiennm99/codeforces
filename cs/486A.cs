using System;

namespace _486A
{
	class Program
	{
		static void Main(string[] args)
		{
			ulong n = ulong.Parse(Console.ReadLine());
			Console.WriteLine(n % 2 == 0 ? (n / 2).ToString() : "-" + ((n + 1) / 2).ToString());
		}
	}
}
