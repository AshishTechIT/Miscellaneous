using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        
        string input = Console.ReadLine();
        DateTime dt = new DateTime();

            dt = Convert.ToDateTime(input);
            Console.WriteLine(dt.TimeOfDay);
    }
}
