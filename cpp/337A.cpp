#include <iostream>

using namespace std;

int main()
{
    int n, m;
    cin >> n >> m;
    int *a = new int[m];
    for (int i = 0; i < m; i++)
    {
        cin >> a[i];
    }
    for (int i = 0; i < m - 1; i++)
    {
         for (int j = i + 1; j < m; j++)
         {
             if (a[j] < a[i])
             {
                 int t = a[i];
                 a[i] = a[j];
                 a[j] = t;
             }
         }
    }
    int delta = a[n - 1] - a[0];
    for (int i = 1; i <= m - n; i++)
    {
        int temp = a[i + n - 1] - a[i];
        if (temp < delta)
        {
            delta = temp;
        }
    }
    cout << delta;
    delete[] a;
    return 0;
}
