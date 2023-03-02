using System;

namespace problem_282A
{
    public class problem_282A
    {
        public static void Main(string[] args)
        {
			int n = int.Parse(Console.ReadLine());
			int x = 0;
            while (n-- > 0)
			{
				string s = Console.ReadLine();
				if (s.Contains("++"))
				{
					x++;
				}
				else
				{
					x--;
				}
			}
			Console.Write(x);
        }
    }
}
