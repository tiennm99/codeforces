using System;

namespace problem_381A
{
 class problem_381A
 {
     static void Main(string[] args)
     {
         int n = int.Parse(Console.ReadLine());
         int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
         int[] b = new int[n];
         int l = 0, r = n - 1, s1 = 0, s2 = 0;
         for (int i = 0; i < n; i++)
         {
             if (a[l] >= a[r])
             {
                 b[i] = a[l++];
             }
             else
             {
                 b[i] = a[r--];
             }
         }
         for (int i = 0; i < n; i++)
         {
             if (i % 2 == 0)
             {
                 s1 += b[i];
             }
             else
             {
                 s2 += b[i];
             }
         }
         Console.Write("{0} {1}", s1, s2);
     }
 }
}
