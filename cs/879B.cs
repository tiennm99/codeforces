using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _879B
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] ip = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            if (ip[0] <= ip[1])
            {
                Console.Write("{0}", a.Max());
            }
            else
            {
                int c = 0;
                int t = a[0];
                for (int i = 1; i < ip[0]; i++)
                {
                    if (c == ip[1])
                    {
                        break;
                    }
                    if (t > a[i])
                    {
                        c++;
                    }
                    else
                    {
                        c = 1;
                        t = a[i];
                    }
                }
                Console.Write(t);
            }
        }
    }
}
