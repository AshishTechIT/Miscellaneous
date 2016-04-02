using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        
        int height = int.Parse(Console.ReadLine());
        
        for(int i=1;i<=height;++i)
            {
                 for(int j=1;j<=height;++j)
                   {
                        if(j<=height-i)  
                            {
                            Console.Write(" ");
                        }
                        else
                            {
                            Console.Write("#");
                        }
                }
            Console.WriteLine();
        }
    }
}
