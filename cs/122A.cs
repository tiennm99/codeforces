﻿using System;

namespace _122A
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			if (n % 4 == 0 || n % 7 == 0 || n % 44 == 0 || n % 47 == 0 || n % 74 == 0 || n % 77 == 0 || n % 444 == 0 || n % 447 == 0 || n % 474 == 0 || n % 477 == 0 || n % 744 == 0 || n % 747 == 0 || n % 774 == 0 || n % 777 == 0)
			{
				Console.WriteLine("YES");
			}
			else
			{
				Console.WriteLine("NO");
			}
		}
	}
}
