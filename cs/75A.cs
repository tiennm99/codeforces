using System;

namespace _75A
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			int c = a + b;
			a = int.Parse(a.ToString().Replace("0", ""));
			b = int.Parse(b.ToString().Replace("0", ""));
			c = int.Parse(c.ToString().Replace("0", ""));
			if (a + b == c)
			{
				Console.WriteLine("YES");
			}
			else
			{
				Console.WriteLine("NO");
			}
		}
	}
}
