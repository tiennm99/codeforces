using System;
using System.Linq;

namespace problem_572A
{
	class problem_572A
	{
		public static void Main(string[] args)
		{
			int[] ip1 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			int[] ip2 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			int[] ip3 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			int[] ip4 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			Array.Sort(ip3);
			Array.Sort(ip4);
			if (ip3[ip2[0] - 1] < ip4[ip1[1] - ip2[1]])
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
