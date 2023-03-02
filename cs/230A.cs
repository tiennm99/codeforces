using System;

namespace problem_230A
{
	class problem_230A
	{
		static void Main(string[] args)
		{
			string[] ip;
			ip = Console.ReadLine().Split(' ');
			int s = int.Parse(ip[0]);
			int n = int.Parse(ip[1]);
            if (C(s, n))
			{
				Console.Write("YES");
			}
			else
			{
				Console.Write("NO");
			}
		}
		static bool C(int s, int n)
		{
			int[] a = new int[n];
			int[] b = new int[n];
			for (int i = 0; i < n; i++)
			{
				string[] ip = Console.ReadLine().Split(' ');
				a[i] = int.Parse(ip[0]);
				b[i] = int.Parse(ip[1]);
			}
			for (int i = 0; i < n - 1; i++)
			{
				for (int j = i + 1; j < n; j++)
				{
					if (a[i] > a[j])
					{
						int t = a[i];
						a[i] = a[j];
						a[j] = t;
						t = b[i];
						b[i] = b[j];
						b[j] = t;
					}
				}
			}
			for (int i = 0; i < n; i++)
            {
                if (s > a[i])
				{
					s += b[i];
				}
				else
				{
					return false;
				}            
            }
			return true;
		}
	}
}