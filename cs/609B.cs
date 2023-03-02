using System;

namespace problem_609A
{
	class problem_609A
	{
		public static void Main(string[] args)
		{
			int[] ip = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			int[] a = new int[ip[1]];
			int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			for (int i = 0; i < ip[0]; i++)
			{
				a[b[i] - 1]++;
			}
			long op = 0;
			for (int i = 0; i < ip[1] - 1; i++)
			{
				for (int j = i + 1; j < ip[1]; j++)
				{
					op += a[i] * a[j];
				}
			}
			Console.Write("{0}", op);
		}
	}
}
