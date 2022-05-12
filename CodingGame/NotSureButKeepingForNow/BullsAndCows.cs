//using System;
//using System.Collections.Generic;
//using System.Linq;

//// https://www.codingame.com/ide/puzzle/bulls-and-cows


//Not current working so not Solved!!!!



////N is hte number of Guesses
//int N = int.Parse(Console.ReadLine());

//Attempt[] stats = new Attempt[N];
//for(int i = 0; i < N; i++)
//{
//    string[] inputs = Console.ReadLine().Split(' ');
//    stats[i] = new Attempt() 
//    {        
//        Guessed = inputs[0], 
//        Correct = int.Parse(inputs[1]), 
//        OutOfPosition = int.Parse(inputs[2]) 
//    };
//}

////see if any guess had no correct answers and not right but out of postion
//List<int> InvalidNumbers = new List<int>();
//foreach (var stat in stats)
//{
//    if (stat.Correct == 0 && stat.OutOfPosition == 0)
//    {
//        InvalidNumbers.AddRange(stat.Guessed.Select(digit => int.Parse(digit.ToString())));
//    }
//}

////for each invalid number, 


//Console.WriteLine();


//public class Attempt
//{
//    public string Guessed { get; set; }

//    public int Correct { get; set; }

//    public int OutOfPosition { get; set; }
//}

