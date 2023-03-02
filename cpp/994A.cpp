#include <iostream>

using namespace std;

bool b[10];

int main()
{
    unsigned short n, m;
    cin >> n >> m;
    int *a = new int[n];
    for (unsigned short i = 0; i < n; i++)
    {
        cin >> a[i];
    }
    for (unsigned short i = 0; i < m; i++)
    {
        int t;
        cin >> t;
        b[t] = 1;
    }
    for (unsigned short i = 0; i < n; i++)
    {
        if (b[a[i]] == 1)
        {
            cout << a[i] << " ";
        }
    }
    delete[] a;
    a = NULL;
    return 0;
}
