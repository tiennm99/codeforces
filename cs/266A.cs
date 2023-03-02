using System;

namespace problem_266A
{
    public class problem_266A
    {
		public static void Main(string[] args)
        {
			int n = int.Parse(Console.ReadLine());
			char[] a = Console.ReadLine().ToCharArray();
			int c = 0;
			for (int i = 1; i < n; i++)
			{
				if (a[i] == a[i - 1])
				{
					c++;
				}
			}
			Console.Write(c);
        }
    }
}
