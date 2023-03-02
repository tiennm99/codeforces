#include <iostream>
#include <sstream>

#define MAX_SIZE 100

using namespace std;

int main()
{
    string s;
    stringstream ss;
    getline(cin, s);
    ss.str(s);
    int arr[MAX_SIZE];
    char c;
    int n = 0;
    while(!ss.eof())
    {
        ss >> arr[n++] >> c;
    }
    for (int i = 0; i < n; i++)
    {
        for (int j = i + 1; j < n; j++)
        {
            if (arr[j] < arr[i])
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
    for (int i = 0; i < n; i++)
    {
        cout << arr[i];
        if (i != n - 1)
        {
            cout << '+';
        }
    }
    cout << endl;
    return 0;
}
