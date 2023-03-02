#include <iostream>

using namespace std;

bool check(int n)
{
    int a = n/1000;
    int b = (n/100)%10;
    if (b == a)
    {
        return 0;
    }
    int c = (n/10)%10;
    if (c == a || c == b)
    {
        return 0;
    }
    int d = n%10;
    if (d == a || d == b || d == c)
    {
        return 0;
    }
    return 1;
}

int main()
{
    int n;
    cin >> n;
    do
    {
        n++;
    } while (check(n) == 0);
    cout << n;
    return 0;
}
