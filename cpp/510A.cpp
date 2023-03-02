#include <iostream>

using namespace std;

int main()
{
    int n, m;
    cin >> n >> m;
    for (int i = 0; i < n ; i++)
    {
        switch (i%4)
        {
        case 1:
            for (int i = 0; i < m - 1; i++)
            {
                cout << ".";
            }
            cout << "#" << endl;
            break;
        case 3:
            cout << "#";
            for (int i = 0; i < m - 1; i++)
            {
                cout << ".";
            }
            cout << endl;
            break;
        default:
            for (int i = 0; i < m; i++)
            {
                cout << "#";
            }
            cout << endl;
        }
    }
    return 0;
}
