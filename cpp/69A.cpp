#include <iostream>

using namespace std;

int main()
{
    int n, x, y, z;
    cin >> n;
    x = y = z = 0;
    for (int i = 0; i < n; i++)
    {
        int t;
        cin >> t;
        x += t;
        cin >> t;
        y += t;
        cin >> t;
        z += t;
    }
    if (x == 0 && y == 0 && z == 0)
    {
        cout << "YES";
    }
    else
    {
        cout << "NO";
    }
    return 0;
}
