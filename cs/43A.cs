using System;

namespace problem_43A
{
	class problem_43A
	{
		public static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			string t1 = Console.ReadLine();
			string t2 = "";
			int c1 = 1, c2 = 0;
			for (int i = 1; i < n; i++)
			{
				string t = Console.ReadLine();
				if (t == t1)
				{
					c1++;
				}
				else
				{
					t2 = t;
					c2++;
				}
			}
			if (c1 > c2)
			{
				Console.Write(t1);
			}
			else
			{
				Console.Write(t2);
			}
		}
	}
}
