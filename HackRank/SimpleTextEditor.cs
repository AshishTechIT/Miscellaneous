using System;
using System.Collections.Generic;
using System.IO;
using System.Collections;
class Solution {
    static string final_string = string.Empty;
    
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int tasks = Convert.ToInt32(Console.ReadLine());
            Stack stack = new Stack();

            for (int i = 0; i < tasks; i++)
            {
                string s = Console.ReadLine();
                output(s, stack);
                //Console.WriteLine(st);
            }
    }
    static void output(string input, Stack sta)
        {
            string[] sp = input.Split(' ');
            int order = Convert.ToInt32(sp[0]);
            int k;
            switch (order)
            {
                case 1:
                    sta.Push(final_string);
                    final_string += sp[1];
                    break;

                case 2:
                    sta.Push(final_string);
                    k = Convert.ToInt32(sp[1]);
                    final_string = final_string.Substring(0, final_string.Length - k);
                    break;

                case 3:
                    k = Convert.ToInt32(sp[1])- 1;
                    Console.WriteLine(final_string[(k)]);
                    break;

                default:
                    final_string = (string)sta.Pop();
                    break;
            }
        }
}
