#include <iostream>

using namespace std;

bool arr[200000];

int main()
{
    unsigned int n, c = 0;
    cin >> n;
    while (n--)
    {
        int t;
        cin >> t;
        if (t < 0)
        {
            t += 200001;
        }
        if (arr[t - 1] == 0 && t != 0)
        {
            c++;
            arr[t - 1] = 1;
        }
    }
    cout << c;
    return 0;
}
