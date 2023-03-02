using System;

namespace problem_1A
{
    class problem_1A
    {
		static void Main(string[] args)
		{
			string s = Console.ReadLine();
			string[] input = s.Split(' ');
			long m = Convert.ToInt32(input[0]);
			long n = Convert.ToInt32(input[1]);
			long a = Convert.ToInt32(input[2]);
			if (a != 0)
			{
				if (m % a == 0)
				{
					m /= a;
				}
				else
				{
					m = m / a + 1;
				}
				if (n % a == 0)
				{
					n /= a;
				}
				else
				{
					n = n / a + 1;
				}
			}
			Console.WriteLine(m * n);
		}
	}
}