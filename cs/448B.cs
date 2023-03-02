using System;

namespace _448B
{
	class Program
	{
		static void Main(string[] args)
		{
			string s1 = Console.ReadLine();
			string s2 = Console.ReadLine();
			char[] c1 = s1.ToCharArray();
			char[] c2 = s2.ToCharArray();
			Array.Sort(c1);
			Array.Sort(c2);
			if (Cnt(s1, s2) == s2.Length)
			{
				Console.WriteLine("automaton");
			}
			else if (new string(c1) == new string(c2))
			{
				Console.WriteLine("array");
			}
			else if (Cnt(new string(c1), new string(c2)) == s2.Length)
			{
				Console.WriteLine("both");
			}
			else
			{
				Console.WriteLine("need tree");
			}
		}
		static int Cnt(string s1, string s2)
		{
			int id = 0, cnt = 0;
			for (int i = 0; i < s2.Length; i++)
			{
				for (int j = id; j < s1.Length; j++)
				{
					if (s1[j] == s2[i])
					{
						id = j + 1;
						cnt++;
						break;
					}
				}
				if (cnt == s2.Length)
				{
					break;
				}
			}
			return cnt;
		}
	}
}
