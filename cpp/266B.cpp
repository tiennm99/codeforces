#include <iostream>
#include <string>

using namespace std;

int main()
{
    int n, t;
    cin >> n >> t;
    string s;
    cin >> s;
    while (t--)
    {
        for (string::iterator i = s.begin(); i != s.end(); i++)
        {
            if (*i == 'B' && *(i + 1) == 'G')
            {
                *i = 'G';
                *(i + 1) = 'B';
                i++;
            }
        }
    }
    cout << s;
    return 0;
}
