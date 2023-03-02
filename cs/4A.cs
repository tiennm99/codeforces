using System;

namespace problem_4A
{
	class problem_4A
	{
		static void Main()
		{
			int n = int.Parse(Console.ReadLine());
            if (n > 2 && n%2 == 0)
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