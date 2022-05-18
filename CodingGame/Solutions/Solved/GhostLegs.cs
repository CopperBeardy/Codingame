using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.codingame.com/training/easy/ghost-legs
public static class GhostLegs
{
  

    public static void Solve()
    {
        string[] line = Console.ReadLine().Split();
        int W = int.Parse(line[0]);
        int H = int.Parse(line[1]);
List<string> lines = new List<string>();
        string startLine = Console.ReadLine().Replace(" ", string.Empty);

        for(int i = 0; i < H - 2; i++)
        {
            var current = Console.ReadLine();
            if(current.Contains('-'))
            {
                lines.Add(current);
            }
        }

        string endLine = Console.ReadLine().Replace(" ", string.Empty);

        List<int> positions = new List<int>();
        for(int i = 0; i < startLine.Length; i++)
        {
            positions.Add(i);
        }

        foreach(var l in lines)
        {
            var current = l.Split('|');

            for(int i = 0; i < current.Length; i++)
            {
                if(current[i] == "--")
                {
                    for(int j = 0; j < positions.Count; j++)
                    {
                        if(positions[j] == i - 1)
                        {
                            positions[j] += 1;
                        } else if(positions[j] == i)
                        {
                            positions[j] -= 1;
                        }
                    }
                }
            }
        }


        for(int i = 0; i < positions.Count; i++)
        {
            Console.WriteLine($"{startLine[i]}{endLine[positions[i]]}");
        }
    }
}
