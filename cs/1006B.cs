using System;
using System.Linq;

namespace problem_1006B
{
	class problem_1006B
	{
		static void Main(string[] args)
		{
			int[] ip = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			if (ip[1] == 1)
			{
				Console.WriteLine("{0}", a.Max());
				Console.Write("{0}", ip[0]);
			}
			else
			{
				int[] b = new int[ip[1]];
				int s = 0;
				for (int i = 0; i < ip[1]; i++)
				{
					int m = a.Max();
					s += m;
					b[i] = Array.IndexOf(a, m);
					a[b[i]] = 0;
				}
				Array.Sort(b);
				Console.WriteLine(s);
				Console.Write("{0} ", b[0] + 1);
				for (int i = 1; i < ip[1] - 1; i++)
				{
					Console.Write("{0} ", b[i] - b[i - 1]);
				}
				Console.Write("{0}", ip[0] - b[ip[1] - 2] - 1);
			}
		}
	}
}
