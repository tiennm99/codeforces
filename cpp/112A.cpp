#include <iostream>
#include <string>
#include <cctype>

using namespace std;

void low(string &s)
{
    for (unsigned int i = 0; i < s.length(); i++)
    {
        if (isupper(s[i]))
        {
            s[i] = tolower(s[i]);
        }
    }
}

int compare(string s1, string s2)
{
    int l;
    if (s1.length() > s2.length())
    {
        l = s2.length();
    }
    else
    {
        l = s1.length();
    }
    for (int i = 0; i < l; i++)
    {
        if (s1[i] > s2[i])
        {
            return 1;
        }
        else if (s1[i] < s2[i])
        {
            return -1;
        }
    }
    if (s1.length() > s2.length())
    {
        return 1;
    }
    else if (s1.length() < s2.length())
    {
        return -1;
    }
    else
    {
        return 0;
    }
}

int main()
{
    string s1, s2;
    getline(cin, s1);
    getline(cin, s2);
    low(s1);
    low(s2);
    cout << compare(s1, s2) << endl;
    return 0;
}
