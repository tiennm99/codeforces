#include <iostream>

using namespace std;

int main()
{
    int n;
    cin >> n;
    int count = 1;
    int a;
    cin >> a;
    while (--n)
    {
        int b;
        cin >> b;
        if (b != a)
        {
            count++;
            a = b;
        }
    }
    cout << count;
    return 0;
}
