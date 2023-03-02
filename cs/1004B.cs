using System;

namespace problem_1004B
{
	class problem_1004B
	{
		public static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine().Split(' ')[0]);
			for (int i = 0; i < n; i++)
			{
				if (i % 2 == 0)
				{
					Console.Write("1");
				}
				else
				{
					Console.Write("0");
				}
			}
		}
	}
}
