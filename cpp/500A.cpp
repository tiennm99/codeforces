#include <iostream>

using namespace std;

int main()
{
    int n, t;
    cin >> n >> t;
    int *a = new int[n - 1];
    for (int i = 0; i < n - 1; i++)
    {
        cin >> a[i];
    }
    int pos = 0;
    while (pos < t - 1)
    {
        pos += a[pos];
    }
    if (pos == t - 1)
    {
        cout << "YES";
    }
    else
    {
        cout << "NO";
    }
    delete[] a;
    a = NULL;
    return 0;
}
