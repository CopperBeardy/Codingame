using System;
using System.Collections.Generic;

public static class ASCII_Art
{
    public static void Solve()
    {
        int L = int.Parse(Console.ReadLine());
        int H = int.Parse(Console.ReadLine());
        string T = Console.ReadLine();
        string[] alpha = new string[]
        {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"
        };
        List<int> postions = new List<int>();

        foreach(var letter in T)
        {
            var index = -1;
            for(var i = 0; i < alpha.Length; i++)
            {
                var l = letter.ToString().ToUpper();
                if(alpha[i].Equals(l))
                {
                    index = i;
                    break;
                }
            }
            if(index < 0)
            {
                postions.Add(26);
            } else
            {
                postions.Add(index);
            }
        }
        List<string> line = new List<string>();
        for(int i = 0; i < H; i++)
        {
            string temp = string.Empty;
            string ROW = Console.ReadLine();
            for(var j = 0; j < postions.Count; j++)
            {
                var ind = postions[j] * L;
                temp = $"{temp}{(ROW.Substring(ind, L))}";
            }
            line.Add(temp);
        }

        foreach(string hash in line)
        {
            Console.WriteLine(hash);
        }
        ;
    }
}
