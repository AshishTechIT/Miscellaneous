using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int T = Convert.ToInt16(Console.ReadLine());
string str = Console.ReadLine();
int K = Convert.ToInt16(Console.ReadLine());
foreach (char ch in str)
{
Int16 chAscii = Convert.ToInt16(ch);
if (chAscii >= 65 && chAscii <= 90)
{
    Console.Write(Convert.ToChar(65+((chAscii-65) + K)%26));

}
else if (chAscii >= 97 && chAscii <= 122)
{
    Console.Write(Convert.ToChar(97+((chAscii-97) + K)%26));
//Console.Write(Convert.ToChar(97 + ((chAscii – 97) + K) % 26));
}
else
{
Console.Write(ch);
}
}
    }
}
