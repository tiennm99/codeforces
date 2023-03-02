using System;

namespace problem_999B
{
    class problem_999B
    {
		static void Main(string[] args)
        {
			int n = int.Parse(Console.ReadLine());
			string s = Console.ReadLine();
			for (int i = 1; i <= n; i++)
			{
				if (n%i == 0)
				{
					s = Reverse(s.Substring(0, i)) + s.Substring(i);
				}
			}
			Console.Write(s);
        }
		public static string Reverse(string s)
		{
			char[] a = s.ToCharArray();
			char[] b = new char[s.Length];
			for (int i = 0; i < s.Length; i++)
			{
				b[i] = a[s.Length - 1 - i];
			}
			return new string(b);
		}
    }
}
