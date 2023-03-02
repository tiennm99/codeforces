using System;

namespace problem_246A
{
	class problem_246A
	{
		public static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			if (n < 3)
			{
				Console.Write("{0}", -1);
			}
			else
			{
				for (int i = n; i > 0; i--)
				{
					Console.Write("{0} ", i);
				}
			}
		}
	}
}
