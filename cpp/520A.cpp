#include <iostream>
#include <string>
#include <cctype>

using namespace std;

bool check(string s)
{
    for (string::iterator it = s.begin(); it != s.end(); it++)
    {
        *it = toupper(*it);
    }
    for (unsigned char c = 'A'; c <= 'Z'; c++)
    {
        if (s.find(c) == -1)
        {
            return 0;
        }
    }
    return 1;
}

int main()
{
    unsigned short n;
    string s;
    cin >> n >> s;
    if (check(s))
    {
        cout << "YES";
    }
    else
    {
        cout << "NO";
    }
    return 0;
}
