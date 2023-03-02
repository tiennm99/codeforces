using System;

namespace _479A
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			int c = int.Parse(Console.ReadLine());
			Console.WriteLine(Math.Max(a + b + c, Math.Max(a * b * c, Math.Max(a + b * c, Math.Max(a * b + c, Math.Max((a + b) * c, a * (b + c)))))));
		}
	}
}
