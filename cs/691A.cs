using System;

namespace problem_691A
{
	class problem_691A
	{
		public static void Main(string[] args)
		{
			Console.ReadLine();
			string s = Console.ReadLine();
			if ((s.IndexOf('0') == s.LastIndexOf('0') && s.Contains("0") && s.Contains("1")) || s == "1")
			{
				Console.Write("YES");
			}
			else
			{
				Console.Write("NO");
			}
		}
	}
}
