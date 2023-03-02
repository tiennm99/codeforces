using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _600B
{
    class Program
    {
        static int FindFirstIndexGreaterThanOrEqualTo(ref List<int> sortedCollection, int key)
        {
            int begin = 0;
            int end = sortedCollection.Count;
            while (end > begin)
            {
                int index = (begin + end) / 2;
                int el = sortedCollection[index];
                if (el > key)
                    end = index;
                else
                    begin = index + 1;
            }
            return end;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            //int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            //int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            List<int> a = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();
            List<int> b = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();
            a.Sort();
            for (int i = 0; i < b.Count; i++)
            {
                Console.Write("{0} ", FindFirstIndexGreaterThanOrEqualTo(ref a, b[i]));
            }
        }
    }
}
