using System;

namespace problem_339A
{
    public class problem_339A
    {
		public static void Main(string[] args)
        {
			int[] a = Array.ConvertAll(Console.ReadLine().Split('+'), int.Parse);
			for (int i = 0; i < a.Length - 1; i++)
			{
				for (int j = i + 1; j < a.Length; j++)
				{
					if (a[j] < a[i])
					{
						int t = a[j];
						a[j] = a[i];
						a[i] = t;
					}
				}
			}
			Console.Write("{0}", a[0]);
			for (int i = 1; i < a.Length; i++)
			{
				Console.Write("+{0}", a[i]);
			}
        }
    }
}
