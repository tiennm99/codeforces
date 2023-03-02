using System;

namespace _61B
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] c = new string[3];
			for (int i = 0; i < 3; i++)
			{
				c[i] = Console.ReadLine().Replace("-", "").Replace(";", "").Replace("_", "").ToLower();
			}
			string s1 = c[0] + c[1] + c[2];
			string s2 = c[0] + c[2] + c[1];
			string s3 = c[1] + c[2] + c[0];
			string s4 = c[1] + c[0] + c[2];
			string s5 = c[2] + c[0] + c[1];
			string s6 = c[2] + c[1] + c[0];
			int n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				string s = Console.ReadLine().Replace("-", "").Replace(";", "").Replace("_", "").ToLower();
				if (s == s1 || s == s2 || s == s3 || s == s4 || s == s5 || s == s6)
				{
					Console.WriteLine("ACC");
				}
				else
				{
					Console.WriteLine("WA");
				}
			}
		}
	}
}
