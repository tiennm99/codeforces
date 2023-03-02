#include <iostream>

using namespace std;

int main()
{
    int a, b;
    cin >> a >> b;
    if (a > b)
    {
        a = b;
    }
    if (a%2)
    {
        cout << "Akshat";
    }
    else
    {
        cout << "Malvika";
    }
    return 0;
}
