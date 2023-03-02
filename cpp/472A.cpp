#include <iostream>

using namespace std;

int main()
{
    int n;
    cin >> n;
    bool *b = new bool[n];
    b[0] = b[1] = 0;
    for (int i = 2; i < n; i++)
    {
        b[i] = 1;
    }
    for (int i = 0; i < n; i++)
    {
        if (b[i] == 1)
        {
            for (int j = 2*i; j < n; j += i)
            {
                b[j] = 0;
            }
        }
    }
    for (int i = 2; i < n; i++)
    {
        if (b[i] == 0 && b[n - i] == 0)
        {
            cout << i << " " << n - i;
            break;
        }
    }
    delete[] b;
    return 0;
}
