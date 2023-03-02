using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _451B
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int i = 0, c = 0, l = 1, r = 1;
            bool b = false;
            while (i < n - 1)
            {
                if (a[i] < a[i + 1])
                {
                    i++;
                }
                else
                {
                    int j = i;
                    while (j < n - 1 && a[j] > a[j + 1])
                    {
                        j++;
                    }
                    l = i + 1;
                    r = j + 1;
                    c++;
                    i = r;
                }
            }
            if (c < 2)
            {
                int c1 = l > 1 ? a[l - 2] : 0;
                int c2 = r < n ? a[r] : int.MaxValue;
                if (a[r - 1] > c1 && a[l - 1] < c2)
                {
                    b = true;
                }
                
            }
            if (b)
            {
                Console.WriteLine("yes");
                Console.WriteLine("{0} {1}", l, r);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
