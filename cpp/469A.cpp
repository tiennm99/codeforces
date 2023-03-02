#include <iostream>

using namespace std;

void input(bool *a, int n, int x)
{
    for (int i = 0; i < n; i++)
    {
        a[i] = 0;
    }
    for (int i = 0; i < x; i++)
    {
        int t1;
        cin >> t1;
        for (int j = 0; j < t1; j++)
        {
            int t2;
            cin >> t2;
            a[t2 - 1] = 1;
        }
    }
}

bool check(bool *a, int x)
{
    for (int i = 0; i < x; i++)
    {
        if (a[i] == 0)
        {
            return 0;
        }
    }
    return 1;
}

int main()
{
    int n;
    cin >> n;
    bool *a = new bool[n];
    input (a, n, 2);
    if (check(a, n))
    {
        cout << "I become the guy.";
    }
    else
    {
        cout << "Oh, my keyboard!";
    }
    return 0;
}
