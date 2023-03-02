#include <iostream>

using namespace std;

int main()
{
    int n;
    cin >> n;
    int a[4];
    for (int i = 0; i < 4; i++)
    {
        a[i] = 0;
    }
    for (int i = 0; i < n; i++)
    {
        int t;
        cin >> t;
        switch (t)
        {
        case 1:
            a[0]++;
            break;
        case 2:
            a[1]++;
            break;
        case 3:
            a[2]++;
            break;
        case 4:
            a[3]++;
            break;
        }
    }
    int count = 0;
    int s = 0;
    count += a[3];
    count += a[2];
    if (a[0] >= a[2])
    {
        a[0] -= a[2];
    }
    else
    {
        a[0] = 0;
    }
    count += a[1]/2;
    a[1] %= 2;
    s += a[1]*2 + a[0];
    if (s%4)
    {
        count += (s/4 + 1);
    }
    else
    {
        count += s/4;
    }
    cout << count << endl;
    return 0;
}
