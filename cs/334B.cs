using System;
using System.Linq;

namespace _334B
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] x = new int[8];
			int[] y = new int[8];
			for (int i = 0; i < 8; i++)
			{
				int[] ip = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
				x[i] = ip[0];
				y[i] = ip[1];
			}
			int[] xx = x.Distinct().ToArray();
			int[] yy = y.Distinct().ToArray();
			bool b = false;
			if (xx.Length == 3 && yy.Length == 3)
			{
				Array.Sort(xx);
				Array.Sort(yy);
				b = true;
				for (int i = 0; i < 3; i++)
				{
					for (int j = 0; j < 3; j++)
					{
						if (i != 1 || j != 1)
						{
							bool c = false;
							for (int k = 0; k < 8; k++)
							{
								if (x[k] == xx[i] && y[k] == yy[j])
								{
									c = true;
									break;
								}
							}
							b &= c;
						}
						if (b == false)
						{
							break;
						}
					}
					if (b == false)
					{
						break;
					}
				}
			}
			if (b)
			{
				Console.WriteLine("respectable");
			}
			else
			{
				Console.WriteLine("ugly");
			}
		}
	}
}
