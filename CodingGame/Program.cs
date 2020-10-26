using System;
using System.Linq;

class Solution
{
    static void Main(string[] args)
    {
        int r1 = int.Parse(Console.ReadLine());
        bool flag = false;

        for (int i = r1; i > r1 - (r1.ToString().Length * 9); i--)
        {
            if (i > 0)
            {
                var count = i;
                count += count.ToString()
                   .Select(p => int.Parse(new string(p, 1)
                   .ToArray()))
                   .Sum();
                if (count == r1)
                {
                    flag = true;
                }
            }
        }
        Console.WriteLine(flag == true ? "YES" : "NO");
    }
}