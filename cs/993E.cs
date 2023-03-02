using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace problem_993E
{
    class problem_993E
	{
		public static void Main(string[] args)
        {
			const double pi = 3.14159265359;
            const int N = 800005;
			int n, m, x, l, L = 0;
            int[] s = new int[N];
            int[] R = new int[N];
            int[] c = new int[N];
            C[] a = new C[N];
            C[] b = new C[N];
			int[] ip = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			n = ip[0];
			x = ip[1];
			c[0]++;
			ip = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			for (int i = 1; i <= n; i++)
			{
				s[i] = s[i - 1] + Convert.ToInt32(ip[i - 1] < x);
				c[s[i]]++;
			}
			for (int i = 0; i <= n; i++)
			{
				a[i].r = c[i];
				b[i].r = c[n - i];
			}
			m = (n << 1);
			for (l = 1; l <= m; l <<= 1)
			{
				L++;
			}
			for (int i = 0; i < l; i++)
			{
				R[i] = (R[i >> 1] >> 1| ((i & 1) << (L - 1)));
			}
			F(a, 1, l, R, pi);
			F(b, 1, l, R, pi);
			for (int i = 0; i < l; i++)
			{
				a[i] *= b[i];
			}
			F(a, -1, l, R, pi);
			Console.Write("{0}", (long)(a[n].r / l + 0.5 - n) >> 1);
			for (int i = 1; i <= n; i++)
			{
				Console.Write(" {0}", (long)(a[i + n].r / l + 0.5));
			}
        }
		public static void F(C[] A, int o, int l, int[] R, double pi)
		{
			for (int i = 0; i < l; i++)
			{
				if (i < R[i])
				{
					S(A, i, R[i]);
				}
			}
			for (int i = 1; i < l; i <<= 1)
			{
				C x, y, wn = new C(Math.Cos(pi / i), Math.Sin(pi * o / i));
				for (int j = 0; j < l; j += (i << 1))
				{
					C w = new C(1, 0);
					for (int k = 0; k < i; k++, w *= wn)
					{
						x = A[j + k];
						y = w * A[j + k + i];
						A[j + k] = x + y;
						A[j + k + i] = x - y;
					}
				}
			}
            
		}
		public static void S(C[] A, int p1, int p2)
		{
			C t = A[p1];
			A[p1] = A[p2];
			A[p2] = t;
		}
    }
	public struct C
	{
		public double r;
		public double i;      
		public C(double r, double i)
		{
			this.r = r;
			this.i = i;
		}
		public static C operator + (C l, C r)
		{
			return new C(l.r + r.r, l.i + r.i);
		}
		public static C operator - (C l, C r)
		{
			return new C(l.r - r.r, l.i - r.i);
		}
		public static C operator * (C l, C r)
		{
			return new C(l.r * r.r - l.i * r.i, l.r * r.i + l.i * r.r);
		}
	}
}
