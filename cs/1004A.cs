using System;

namespace problem_1004A
{
    public class problem_1004A
    {
        public static void Main(string[] args)
        {
			int[] ip = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			int n = ip[0];
			int d = ip[1];
			ip = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			int id = 1;
			int count = 2;
            while (id < n)
			{
				if (ip[id] - ip[id - 1] > 2*d)
				{
					count += 2;
				}
				else if (ip[id] - ip[id - 1] == 2*d)
				{
					count++;
				}
				id++;
			}
			Console.Write("{0}", count);
        }
    }
}
