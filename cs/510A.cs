using System;

namespace problem_510A
{
	class problem_510A
	{
		static void Main(string[] args)
		{
			int[] ip = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			for (int i = 0; i < ip[0]; i++)
			{
				switch (i % 4)
				{
					case 1:
						for (int j = 1; j < ip[1]; j++)
						{
							Console.Write(".");
						}
						Console.WriteLine("#");
						break;
					case 3:
						Console.Write("#");
						for (int j = 1; j < ip[1]; j++)
						{
							Console.Write(".");
						}
						Console.WriteLine();
						break;
					default:
						for (int j = 0; j < ip[1]; j++)
						{
							Console.Write("#");
						}
						Console.WriteLine();
						break;
				}
			}
		}
	}
}
