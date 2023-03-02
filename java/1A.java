package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        long n = sc.nextInt();
        long m = sc.nextInt();
        long a = sc.nextInt();
        long r = n / a, c = m / a;
        if (n % a != 0)
        {
            r++;
        }
        if (m % a != 0)
        {
            c++;
        }
        long s = r * c;
        System.out.println(s);
    }
}