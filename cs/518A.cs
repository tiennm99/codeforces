using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _518A
{
	class Program
	{
		static void Main(string[] args)
		{
			string c1 = Console.ReadLine();
			string c2 = Console.ReadLine();
			StringBuilder s1 = new StringBuilder(c1);
			StringBuilder s2 = new StringBuilder(c2);
			bool b;
			if (s1.ToString() == s2.ToString())
			{
				b = false;
			}
			else
			{
				int j = s1.Length - 1;
				for (; j >= 0; j--)
				{
					if (s1[j] == 'z')
					{
						s1[j] = 'a';
					}
					else
					{
						s1[j] = Convert.ToChar(s1[j] + 1);
						break;
					}
				}
				if (j == -1 || s1.ToString() == s2.ToString())
				{
					b = false;
				}
				else
				{
					b = true;
				}
			}
			if (b)
			{
				Console.WriteLine(s1);
			}
			else
			{
				Console.WriteLine("No such string");
			}
		}
	}
}
