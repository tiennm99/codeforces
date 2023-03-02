using System;

namespace problem_996A
{
	class problem_996A
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[] a = { 1, 5, 10, 20, 100 };
			int i = 4;
			int s = 0;
            while (n > 0 && i >= 0)
			{
				s += n / a[i];
				n %= a[i];
				i--;
			}
			Console.Write(s);
		}
	}
}