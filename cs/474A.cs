using System;

namespace problem_474A
{
	class Program
	{
		static void Main(string[] args)
		{
			string s = "qwertyuiop[]\\asdfghjkl;'zxcvbnm,./";
			string c = Console.ReadLine();
			string ip = Console.ReadLine();
			string op = "";
			if (c == "R")
			{
				for (int i = 0; i < ip.Length; i++)
				{
					int p = s.IndexOf(ip[i]);
					if (p != -1)
					{
						op += s[p - 1];
					}
				}
			}
			else
			{
				for (int i = 0; i < ip.Length; i++)
				{
					int p = s.IndexOf(ip[i]);
					if (p != -1)
					{
						op += s[p + 1];
					}
				}
			}
			Console.WriteLine(op);
		}
	}
}
