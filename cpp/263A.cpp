#include <iostream>
#include <cstdlib>
#include <cmath>

using namespace std;

int main()
{
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            int t;
            cin >> t;
            if (t == 1)
            {
                cout << abs(i - 2) + abs(j - 2) << endl;
                exit(0);
            }
        }
    }
    return 0;
}
