#include <iostream>
#include <cstdlib>

using namespace std;

int main()
{
    int n;
    cin >> n;
    int i1, i2, c1 = 0, c2 = 0;
    while (n--)
    {
        int t;
        cin >> t;
        if (t%2)
        {
            c1++;
            i1 = c1 + c2;
        }
        else
        {
            c2++;
            i2 = c1 + c2;
        }
    }
    if (c1 < c2)
    {
        cout << i1;
    }
    else
    {
        cout << i2;
    }
    return 0;
}
