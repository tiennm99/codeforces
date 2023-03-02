#include <iostream>
#include <string>

using namespace std;

int main()
{
    string s;
    cin >> s;
    unsigned int i = 0;
    while (i < s.length()) {
        unsigned int index = s.find_last_of(s[i]);
        while (index != i) {
            s.replace(index, 1, "");
            index = s.find_last_of(s[i]);
        }
        i++;
    }
    if (s.length()%2) {
        cout << "IGNORE HIM!";
    }
    else {
        cout << "CHAT WITH HER!";
    }
    cout << endl;
    return 0;
}
