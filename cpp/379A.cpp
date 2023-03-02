#include <iostream>

using namespace std;

int main()
{
    int a, b, d = 0, c = 0;
    cin >> a >> b;
    do
    {
        while (a > 0)
        {
            c += a;
            d += a%b;
            a /= b;
        }
        a = d/b;
        d %= b;
    }
    while (a > 0);
    cout << c;
    return 0;
}
