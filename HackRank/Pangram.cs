using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        
        String s = Console.ReadLine().ToLower();
            char[] c = s.ToCharArray();
            int[] a = new int[26];
            int t, f = 1;
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] != 32)
                {
                    t = c[i] - 'a';
                    a[t] = 1;
                }
            }
            for (int i = 0; i < 26; i++)
            {
                if (a[i] != 1)
                {
                    f = 0;
                    break;
                }
            }
            if (f == 0)
            {
                Console.WriteLine("not pangram");
            }
            else
            {
                Console.WriteLine("pangram");
            }

        
    }
}
