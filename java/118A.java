package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
	// write your code here
        Scanner sc = new Scanner(System.in);
        String s = sc.next();
        s = s.toLowerCase();
        s = s.replaceAll("a", "");
        s = s.replaceAll("e", "");
        s = s.replaceAll("i", "");
        s = s.replaceAll("o", "");
        s = s.replaceAll("u", "");
        s = s.replaceAll("y", "");
        for (int i = 0; i < s.length(); i++)
        {
            System.out.print('.');
            System.out.print(s.charAt(i));
        }
    }
}
