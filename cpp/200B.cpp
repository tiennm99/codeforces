#include <iostream>
#include <iomanip>

using namespace std;

int main() {
    int n;
    int *a;
    double *arr;
    cin >> n;
    a = new int[n];
    for (int i = 0; i < n; ++i)
        a[i] = 1;
    arr = new double[n];
    for (int i = 0; i < n; ++i)
        cin >> arr[i];
    while (n > 1) {
        for (int i = 0; i < n / 2; ++i) {
            int sum = a[i] + a[n - i - 1];
            arr[i] = (double) a[i] / sum * arr[i] + (double) a[n - i - 1] / sum * arr[n - i - 1];
            a[i] = sum;
        }
        n = (n + 1) / 2;
    }
    cout << setprecision(6) << arr[0] << endl;
    return 0;
}