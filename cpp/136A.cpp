#include <iostream>

using namespace std;

int main()
{
    int n;
    cin >> n;
    int *a = new int[n];
    int *b = new int[n];
    for (int i = 0; i < n; i++)
    {
        cin >> a[i];
    }
    for (int i = 0; i < n; i++)
    {
        b[a[i] - 1] = i + 1;
    }
    for (int i = 0; i < n; i++)
    {
        cout << b[i] << " ";
    }
    delete[] a;
    a = NULL;
    delete[] b;
    b = NULL;
    return 0;
}
