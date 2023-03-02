using System;

namespace problem_112A
{
    public class problem_112A
    {
		public static int F(char[] c1, char[] c2)
		{
			int l = Math.Min(c1.Length, c2.Length);
			for (int i = 0; i < l; i++)
			{
				if (c1[i] < c2[i])
				{
					return -1;
				}
				else if (c1[i] > c2[i])
				{
					return 1;
				}
			}
			if (c1.Length > c2.Length)
			{
				return 1;
			}
			else if (c1.Length < c2.Length)
			{
				return -1;
			}
			else
			{
				return 0;
			}
		}
		public static void Main(string[] args)
        {
			char[] c1 = Console.ReadLine().ToLower().ToCharArray();
			char[] c2 = Console.ReadLine().ToLower().ToCharArray();
			Console.Write("{0}", F(c1, c2));
        }
    }
}
