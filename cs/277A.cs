using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _277A
{
	class Program
	{
		static bool[,] board;
		static int[] a;
		static bool[] b;
		static Queue<int> qi = new Queue<int>();
		static void Main(string[] args)
		{
			a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			board = new bool[a[0], a[1]];
			b = new bool[a[0]];
			int count = 0;
			int c = 0;
			for (int i = 0; i < a[0]; i++)
			{
				int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
				if (array[0] == 0)
				{
					c++;
				}
				for (int j = 1; j <= array[0]; j++)
				{
					board[i, array[j] - 1] = true;
				}
			}
			/*
			for (int i = 0; i < a[0]; i++)
			{
				for (int j = 0; j < a[1]; j++)
				{
					Console.Write("{0} ", board[i, j] ? 1 : 0);
				}
				Console.WriteLine();
			}
			*/
			if (c == a[0])
			{
				Console.WriteLine(c);
			}
			else
			{
				for (int i = 0; i < a[0]; i++)
				{
					if (b[i] == false)
					{
						count++;
						DFS(i);
					}
				}
				Console.WriteLine(count - 1);
			}
		}
		static void DFS(int n)
		{
			b[n] = true;
			qi.Enqueue(n);
			while (qi.Count != 0)
			{
				int t = qi.First();
				qi.Dequeue();
				for (int j = 0; j < a[1]; j++)
				{
					if (board[t, j] == true)
					{
						for (int i = 0; i < a[0]; i++)
						{
							if (board[i, j] == true && b[i] == false)
							{
								b[i] = true;
								qi.Enqueue(i);
							}
						}
					}
				}
			}
		}
	}
}
