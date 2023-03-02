using System;
using System.Linq;

namespace problem_1008B
{
    public class problem_1008B
    {
		public static void Main(string[] args)
        {
			int n = int.Parse(Console.ReadLine());
			int c = int.MaxValue;
			bool b = true;
			for (int i = 0; i < n; i++)
			{
				int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
				if (c >= a.Max())
				{
					c = a.Max();
				}
				else if ( c >= a.Min())
				{
					c = a.Min();
				}
				else
				{
					b = false;
					break;
				}
			}
            if (b)
			{
				Console.Write("YES");
			}
			else
			{
				Console.Write("NO");
			}
        }
    }
}
