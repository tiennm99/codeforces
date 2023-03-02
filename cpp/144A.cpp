#include <iostream>

using namespace std;

int main()
{
    int n, o,
        imax = 0,
        imin = 0;
    cin >> n;
    int *a = new int[n];
    for (int i = 0; i < n; i++)
    {
        cin >> a[i];
    }
    for (int i = 1; i < n; i++)
    {
        if (a[i] > a[imax])
        {
            imax = i;
        }
        if (a[i] <= a[imin])
        {
            imin = i;
        }
    }
    o = n - 1 - imin + imax;
    if (imax > imin)
    {
        o--;
    }
    cout << o;
    return 0;
}
