using System;

namespace problem_999A
{
	class problem_999A
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split(' ');
			int n = Convert.ToInt32(input[0]);
			int k = Convert.ToInt32(input[1]);
			input = Console.ReadLine().Split(' ');
			int[] a = new int[n];
			int i;
			for (i = 0; i < n; i++)
			{
				a[i] = Convert.ToInt32(input[i]);
			}
			i = 0;
			int l = 0;
			while (i < n && a[i] <= k)
			{
				l++;
				i++;
			}
			i = n - 1;
			int r = 0;
            while (i >= 0 && a[i] <= k)
			{
				r++;
				i--;
			}
			int ouput = Math.Min(l + r, n);
			Console.WriteLine(ouput);
		}
	}
}