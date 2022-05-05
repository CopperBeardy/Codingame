using System;
using System.Collections.Generic;
using System.Linq;

// https://www.codingame.com/ide/puzzle/bulls-and-cows
char[] AllChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
List<Attempt> Attempts = new List<Attempt>();
int N = int.Parse(Console.ReadLine());
List<string> PossibleCombinations = new List<string>();
List<char> NotPossibleNumbers = new List<char>();
List<char> PossibleNumbers = new List<char>();
GetInputs();
var temp = new List<Attempt>();
foreach(var attempt in Attempts)
{
    if(attempt.Cows != 0 || attempt.Bulls != 0)
    {
        temp.Add(attempt);
    }
}

Attempts = temp;

//GenerateAllCombinations();


Console.WriteLine();


void GetInputs()
{
    for(int i = 0; i < N; i++)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        Attempts.Add(new Attempt { Guess = inputs[0], Bulls = int.Parse(inputs[1]), Cows = int.Parse(inputs[2]) });
    }
}

void GenerateAllCombinations()
{
    for(int i = 0; i <= 9; i++)
    {
        for(int j = 0; j <= 9; j++)
        {
            for(int k = 0; k <= 9; k++)
            {
                for(int l = 0; l <= 9; l++)
                {
                    PossibleCombinations.Add($"{i}{j}{k}{l}");
                }
            }
        }
    }
}

public class Attempt
{
    public string Guess { get; set; }

    public int Bulls { get; set; }

    public int Cows { get; set; }
}