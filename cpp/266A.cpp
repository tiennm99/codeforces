#include <iostream>

using namespace std;

int main()
{
    int n;
    cin >> n;
    char *ptr = new char[n];
    for (int i = 0; i < n; i++)
    {
        cin >> ptr[i];
    }
    int count = 0;
    for (int i = 1; i < n; i++)
    {
        if (ptr[i] == ptr[i - 1])
        {
            count++;
        }
    }
    cout << count << endl;
    delete[] ptr;
    return 0;
}
