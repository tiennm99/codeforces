using System;

namespace _478A
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			int sum = 0;
			for (int i = 0; i < 5; i++)
			{
				sum += a[i];
			}
			Console.WriteLine((sum % 5 == 0 && sum != 0) ? sum / 5 : -1);
		}
	}
}
