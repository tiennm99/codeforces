#include <iostream>

using namespace std;

int main()
{
    const unsigned int size = 5;
    char* c[size] = {"Sheldon", "Leonard", "Penny", "Rajesh", "Howard"};
    int n, m = 0, r = 1;
    cin >> n;
    while (n > m)
    {
        m += size*r;
        r *= 2;
    }
    r /= 2;
    n = n - m + size*r;
    int pos = n/r;
    if (n%r == 0)
    {
        pos--;
    }
    cout << c[pos];
    return 0;
}
