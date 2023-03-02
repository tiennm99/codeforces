using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _119A
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			Console.WriteLine(P(a[0], a[1], a[2]) ? 1 : 0);
		}
		static bool P(int a, int b, int c)
		{
			while (true)
			{
				int gcd = GCD(a, c);
				c -= gcd;
				if (c == 0)
				{
					return false;
				}
				gcd = GCD(b, c);
				c -= gcd;
				if (c == 0)
				{
					return true;
				}
			}
		}
		static int GCD(int a, int b)
		{
			int t;
			while (b != 0)
			{
				t = a % b;
				a = b;
				b = t;
			}
			return a;
		}
	}
}
