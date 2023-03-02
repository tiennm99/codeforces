#include <iostream>
#include <cctype>
#include <string>

using namespace std;

int main()
{
    char c[6] = {'a', 'o', 'y', 'e', 'u', 'i'};
    string s;
    cin >> s;
    for (unsigned int i = 0; i < s.length(); i++)
    {
        if (isupper(s[i]) == 1)
        {
            s[i] = tolower(s[i]);
        }
    }
    for (int i = 0; i < 6; i++)
    {
        while (s.find(c[i]) != -1)
        {
            int pos = s.find(c[i]);
            s.replace(pos, 1, "");
        }
    }
    for (int i = 0; i < s.length(); i += 2)
    {
        s.insert(i, ".");
    }
    cout << s << endl;
    return 0;
}
