using System;
using System.Linq;

namespace problem_387B
{
	class problem_387B
	{
		static void Main(string[] args)
		{
			int[] ip = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			int c = 0;
			int i = a.Length - 1;
			for (int j = b.Length - 1; i >= 0 && j >= 0; i--)
			{
				if (a[i] <= b[j])
				{
					j--;
				}
				else
				{
					c++;
				}
			}
			if (i != -1)
			{
				c += i + 1;
			}
			Console.Write(c);
		}
	}
}
