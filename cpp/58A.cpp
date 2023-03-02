#include <iostream>
#include <string>

using namespace std;

bool check(string s)
{
    string c = "hello";
    for (unsigned int i = 0; i < c.length(); i++)
    {
        int pos = s.find(c[i]);
        if (pos != -1)
        {
            s.replace(0, pos + 1, "");
        }
        else
        {
            return 0;
        }
    }
    return 1;
}

int main()
{
    string s;
    getline(cin, s);
    if (check(s))
    {
        cout << "YES";
    }
    else
    {
        cout << "NO";
    }
    cout << endl;
    return 0;
}
