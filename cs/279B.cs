using System;

namespace problem_279B
{
	class problem_279B
	{
		static void Main(string[] args)
		{
			int[] ip = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			int c = 0, s = 0, x = 0;
			for (int i = 0; i < ip[0]; i++)
			{
				s += a[i];
				c++;
				if (s > ip[1])
				{
					c--;
					s -= a[x];
					x++;
				}
			}
			Console.Write(c);
		}
	}
}
