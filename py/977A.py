n, k = input().split()
n, k = int(n), int(k)
while (k):
    if n % 10 == 0:
        n /= 10
    else:
        n -= 1
    k -= 1
n = int(n)
print(n)