using System;

namespace problem_118A
{
    class problem_118A
    {
		static void Main(string[] args)
        {
			char[] r = {'a', 'o', 'y', 'e', 'u', 'i'};
			string s = Console.ReadLine().ToLower();
			foreach (char c in r)
			{
				s = s.Replace(char.ToString(c), "");
			}
            foreach (char c in s)
			{
				Console.Write(".{0}", c);
			}
        }
    }
}
