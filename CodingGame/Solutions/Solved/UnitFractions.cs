using System;
using System.Collections.Generic;
using System.Linq;

//https://www.codingame.com/ide/puzzle/unit-fractions

public static class UnitFraction
{
    public static void Solve()
    {
        long n = long.Parse(Console.ReadLine());
        long N = n * n;
        for(long i = 1; i < n + 1; i++)
        {
            long x = n + N / i;
            long y = n + i;
            if(x < y)
            {
                break;
            }
            if(N % i == 0)
            {
                Console.WriteLine($"1/{n} = 1/{x} + 1/{y}");
            }
        }
    }
}