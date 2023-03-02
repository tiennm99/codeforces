#include <iostream>
#include <string>

using namespace std;

int main()
{
    unsigned int ca, cd, n;
    string s;
    cin >> n;
    ca = 0;
    cd = 0;
    cin >> s;
    for (string::iterator it = s.begin(); it != s.end(); it++)
    {
        if (*it == 'A')
        {
            ca++;
        }
        else if (*it == 'D')
        {
            cd++;
        }
    }
    if (ca > cd)
    {
        cout << "Anton";
    }
    else if (ca < cd)
    {
        cout << "Danik";
    }
    else
    {
        cout << "Friendship";
    }
    return 0;
}
