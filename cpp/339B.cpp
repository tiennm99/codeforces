#include <iostream>

using namespace std;

int main()
{
    int n, m, now = 1;
    unsigned long long int c = 0;
    cin >> n >> m;
    for (int i = 0; i < m; i++)
    {
        int t;
        cin >> t;
        if (t < now)
        {
            c = c + t + n - now;
        }
        else
        {
            c = c + t - now;
        }
        now = t;
    }
    cout << c;
    return 0;
}
