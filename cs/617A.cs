using System;

namespace _617A
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			Console.WriteLine(n % 5 == 0 ? n / 5 : n / 5 + 1);
		}
	}
}
