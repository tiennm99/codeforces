#include <iostream>
#include <string>
#include <cctype>

using namespace std;

int main()
{
    string s;
    cin >> s;
    int up = 0, low = 0;
    for (string::iterator it = s.begin(); it!= s.end(); it++)
    {
        if (islower(*it))
        {
            low++;
        }
        else if (isupper(*it))
        {
            up++;
        }
    }
    if (up > low)
    {
        for (string::iterator it = s.begin(); it != s.end(); it++)
        {
            *it = toupper(*it);
        }
    }
    else
    {
        for (string::iterator it = s.begin(); it != s.end(); it++)
        {
            *it = tolower(*it);
        }
    }
    cout << s;
    return 0;
}
