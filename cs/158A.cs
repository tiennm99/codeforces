using System;

namespace problem_158A
{
    public class problem_158A
    {
		static void Main(string[] args)
        {
			int[] line_1 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			int[] line_2 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			int c = 0;
			for (int i = 0; i < line_1[0]; i++)
			{
				if (line_2[i] >= line_2[line_1[1] - 1] && line_2[i] > 0)
				{
					c++;
				}
				else
				{
					break;
				}
			}
			Console.WriteLine(c);
        }
    }
}
