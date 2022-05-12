using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

public static class OneDBushFire
{
    public static void Solve()
    {
        int N = int.Parse(Console.ReadLine());
        string[] lines = new string[N];
        for(int i = 0; i < N; i++)
        {
            lines[i] = Console.ReadLine();
        }


        for(int i = 0; i < N; i++)
        {
            char[] line = lines[i].ToCharArray();


            for(int j = 0; j < line.Length; j++)
            {
                if(isF(line[j]))
                {
                    if(j < line.Length - 2)
                    {
                        line[j] = '.';
                        line[j + 1] = '.';
                        line[j + 2] = 'd';
                    } else if(j < line.Length - 1)
                    {
                        line[j] = '.';
                        line[j + 1] = 'd';
                    } else
                    {
                        line[j] = 'd';
                    }
                }
            }
            Console.WriteLine(line.Where(x => x == 'd').Count());
        }
    }

    public static bool isF(char x) => x.Equals('f');
}