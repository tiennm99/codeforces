#include <iostream>
#include <cstdlib>
#include <string>

using namespace std;

int main()
{
    char c[] = "HQ9";
    string s;
    cin >> s;
    for (int i = 0; i < 3; i++) {
        if (s.find(c[i]) != -1) {
            cout << "YES" << endl;
            exit(0);
        }
    }
    cout << "NO" << endl;
    return 0;
}
