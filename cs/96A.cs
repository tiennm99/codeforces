using System;

namespace problem_96A
{
    public class problem_96A
    {
		public static void Main(string[] args)
        {
			string s = Console.ReadLine();
			if (s.Contains("0000000") || s.Contains("1111111"))
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
