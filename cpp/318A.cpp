#include <iostream>

using namespace std;

unsigned long long int out(unsigned long long int n, unsigned long long int k)
{
    if (k <= n/2)
    {
        return 2*k - 1;
    }
    else
    {
        return (k - n/2)*2;
    }
}

int main()
{
    unsigned long long int n, k;
    cin >> n >> k;
    if (n%2)
    {
        cout << out(n + 1, k);
    }
    else
    {
        cout << out(n, k);
    }
    return 0;
}
