#include <iostream>

using namespace std;

int main()
{
    unsigned short i;
    cin >> i;
    if (i%4 && i%7 && i%44 && i%47 && i%77 && i%74 && i%444 && i%447 && i%477 && i%777 && i%774 && i%744 && i%474 && i%747) {
        cout << "NO" << endl;
    }
    else {
        cout << "YES" << endl;
    }
    return 0;
}
