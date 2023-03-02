using System;

namespace problem_996B
{
    class problem_996B
    {
        public static void Main(string[] args)
        {
			int n = int.Parse(Console.ReadLine());
			int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			int m = a[0];
			for (int i = 1; i < n; i++)
			{
				if (a[i] < m)
				{
					m = a[i];
				}
			}
			int p = m % n;
            while (a[p] > m)
			{
				m++;
				p++;
                if (p == n)
				{
					p = 0;
				}
			}
			Console.Write("{0}", p + 1);
        }
    }
}
