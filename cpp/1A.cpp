#include <iostream>

using namespace std;

int main()
{
    unsigned long long n, m, a;
    cin >> n >> m >> a;
    cout << ((n%a) ? (n/a + 1) : (n/a))*((m%a) ? (m/a + 1) : (m/a)) << endl;
    return 0;
}
