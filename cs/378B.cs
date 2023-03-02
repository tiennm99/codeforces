using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _378B
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a1 = new int[n];
            int[] a2 = new int[n];
            int i, j;
            i = 0;
            while (i < n)
            {
                int[] ip = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                a1[i] = ip[0];
                a2[i] = ip[1];
                i++;
            }
            i = n / 2;
            while (a1[i] < a2[n - 1 - i])
            {
                i++;
                if (i == n)
                {
                    break;
                }
            }
            j = 0;
            while (j < i)
            {
                Console.Write("1");
                j++;
            }
            while (j < n)
            {
                Console.Write("0");
                j++;
            }
            Console.WriteLine();
            i = n / 2;
            while (a2[i] < a1[n - 1 - i] && i < n)
            {
                i++;
                if (i == n)
                {
                    break;
                }
            }
            j = 0;
            while (j < i)
            {
                Console.Write("1");
                j++;
            }
            while (j < n)
            {
                Console.Write("0");
                j++;
            }
        }
    }
}
