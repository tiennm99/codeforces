#include <iostream>

using namespace std;

int main()
{
    int n;
    cin >> n;
    int *a = new int[n];
    int sum = 0;
    for (int i = 0; i < n; i++) {
        cin >> a[i];
        sum += a[i];
    }
    for (int i = 0; i < n - 1; i++) {
        for (int j = i + 1; j < n; j++) {
            if (a[i] < a[j]) {
                int t = a[i];
                a[i] = a[j];
                a[j] = t;
            }
        }
    }
    int s = 0, x = 0;
    while (s <= sum) {
        s += a[x];
        sum -= a[x];
        x++;
    }
    cout << x << endl;
    delete[] a;
    return 0;
}
