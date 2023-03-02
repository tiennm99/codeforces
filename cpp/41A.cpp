#include <iostream>
#include <string>

using namespace std;

bool check(string s, string t)
{
    if (s.length() != t.length())
    {
        return 0;
    }
    for (int i = 0; i < s.length(); i++)
    {
        if (s[i] != t[t.length() - 1 -i])
        {
            return 0;
        }
    }
    return 1;
}

int main()
{
    string s, t;
    cin >> s >> t;
    if (check(s, t))
    {
        cout << "YES";
    }
    else
    {
        cout << "NO";
    }
    return 0;
}
