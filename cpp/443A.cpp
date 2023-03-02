#include <iostream>
#include <string>

using namespace std;

int main()
{
    string s;
    int c = 0;
    getline(cin, s);
    for (int i = s.length() - 2; i > 0; i -= 3)
    {
        if (s.find(s[i]) == i)
        {
            c++;
        }
    }
    cout << c;
    return 0;
}
