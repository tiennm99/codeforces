#include <iostream>

using namespace std;

int main()
{
    int n, h, l = 0;
    cin >> n >> h;
    for (int i = 0; i < n; i++)
    {
        int t;
        cin >> t;
        if (t > h)
        {
            l++;
        }
    }
    cout << l + n;
    return 0;
}
