using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        int N = int.Parse(inputs[0]);
        int T = int.Parse(inputs[1]);
        int[][] ins = new int[T][];
        for (int i = 0; i < T; i++)
        {
            inputs = Console.ReadLine().Split(' ');
            var temp = new int[N]; 
            for (int j = 0; j < N; j++)
            {
                temp[j] = int.Parse(inputs[j]);
            }
            ins[i] = temp;
        }

        Dictionary<int, List<int>> matchs = new Dictionary<int, List<int>>();
       
       
        for (int j = 1; j <= 2*N; j++)
        { 
            List<int>allevens = new List<int>();
            for (int l = 2; l <= 2*N; l++)
            {
                if(l%2 == 0)
                {
                    allevens.Add(l);
                }
            }
            if(j %2 != 0)
            {
                matchs.Add(j, allevens);
            }
        }

        foreach (var set in ins)
        {
            for (int i = 0; i < set.Length; i++)
            {
                var val = set[i];
                if(val % 2 != 0)
                {
                    for (int j = 0; j < set.Length; j++)
                    {
                        int val2 = set[j];
                        if ((val != val2 || val2 % 2 == 0) && matchs[val].Contains(val2))
                        {
                            matchs[val].Remove(val2);
                        }
                    }
                }
            }
        }

        int matchFound = 0;
        while (matchFound != N)
        {
            matchFound = 0;
            foreach (var (key, currentSet) in from key in matchs.Keys
                                              let currentSet = matchs[key]
                                              where currentSet.Count == 1
                                              select (key, currentSet))
            {
                matchFound++;
                foreach (var nextSet in from k in matchs.Keys
                                        let nextSet = matchs[k]
                                        where key != k && nextSet.Contains(currentSet[0])
                                        select nextSet)
                {
                    nextSet.Remove(currentSet[0]);
                }
            }
        }

        var output = matchs.Aggregate("", (accumulator, item) => accumulator += $"{item.Value[0]} ");


        Console.WriteLine(output.Trim());
    }



 4
}