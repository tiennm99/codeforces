using System;

namespace _520A
{
	class Program
	{
		static string c = "abcdefghijklmnopqrstuvwxyz";
		static bool Check(string s)
		{
			for (int i = 0; i < 26; i++)
			{
				if (s.IndexOf(c[i]) == -1)
				{
					return false;
				}
			}
			return true;
		}
		static void Main(string[] args)
		{
			string s = Console.ReadLine();
			s = Console.ReadLine().ToLower();
			Console.WriteLine("{0}", Check(s) ? "YES" : "NO");
		}
	}
}
