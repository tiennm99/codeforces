using System;

namespace problem_1000A
{
	class problem_1000A
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
		    int[] a = new int[9];
			for (int i = 0; i<n; i++)
			{
				string s = Console.ReadLine();
                if (s == "M")
				{
					a[0]++;
				}
                else if (s == "S")
				{
					a[1]++;
				}
				else if (s == "XS")
				{
					a[2]++;
				}
				else if (s == "XXS")
				{
					a[3]++;
				}
				else if (s == "XXXS")
				{
					a[4]++;
				}
				else if (s == "L")
                {
                    a[5]++;
                }
                else if (s == "XL")
                {
                    a[6]++;
                }
                else if (s == "XXL")
                {
                    a[7]++;
                }
                else if (s == "XXXL")
                {
                    a[8]++;
                }
			}
			int c = 0;
			for (int i = 0; i < n; i++)
			{
				string s = Console.ReadLine();
				if (s == "M" && a[0] > 0)
                {
                    a[0]--;
                }
				else if (s == "S" && a[1] > 0)
                {
                    a[1]--;
                }
				else if (s == "XS" && a[2] > 0)
                {
                    a[2]--;
                }
				else if (s == "XXS" && a[3] > 0)
                {
                    a[3]--;
                }
				else if (s == "XXXS" && a[4] > 0)
                {
                    a[4]--;
                }
				else if (s == "L" && a[5] > 0)
                {
                    a[5]--;
                }
				else if (s == "XL" && a[6] > 0)
                {
                    a[6]--;
                }
				else if (s == "XXL" && a[7] > 0)
                {
                    a[7]--;
                }
				else if (s == "XXXL" && a[8] > 0)
                {
                    a[8]--;
                }
				else
				{
					c++;
				}
			}
			Console.Write(c);
		}
	}
}