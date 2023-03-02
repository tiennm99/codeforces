#include <iostream>
#include <string>

using namespace std;

int main()
{
    string s;
    cin >> s;
    int sum = 0;
    for (string::iterator i = s.begin(); i != s.end(); i++)
    {
        if (*i == '4' || *i == '7')
        {
            sum++;
        }
    }
    if (sum == 4 || sum == 7)
    {
        cout << "YES";
    }
    else
    {
        cout << "NO";
    }
    return 0;
}
