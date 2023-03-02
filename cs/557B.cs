using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _557B
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] ip = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			double[] a = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
			Array.Sort(a);
			Console.WriteLine(Math.Min(ip[1], ip[0] * Math.Min(a[0] * 3, a[ip[0]] * 3 / 2)).ToString(".##########").Replace(",", "."));
		}
	}
}
