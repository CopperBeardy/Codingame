using System;
using System.Collections.Generic;

//working correct but Test cases 2 & 8 on Codingame is has the wrong value expected on these tests
public static class Scrabble
{
    public static void Solve()
    {
        int N = int.Parse(Console.ReadLine());
        string[] words = new string[N];
        (string word, int value) highestScoringWord = (string.Empty, 0);
        for(int i = 0; i < N; i++)
        {
            words[i] = Console.ReadLine().Trim();
        }
        string letterRack = Console.ReadLine();

        List<string> validWords = new List<string>();

        foreach(var word in words)
        {
            //max word length is 7 characters
            if(word.Length > 7)
                continue;
            if(CheckLetters(word, letterRack))
            {
                validWords.Add(word);
            }
        }

        foreach(var word in validWords)
        {
            var result = ScoreWord(word);
            if(result > highestScoringWord.value)
            {
                highestScoringWord = (word, result);
            } else if(result == highestScoringWord.value)
            {
                string[] WordsToSortAlphabetically = new string[] { highestScoringWord.word, word };
                Array.Sort(WordsToSortAlphabetically);
                highestScoringWord = (WordsToSortAlphabetically[0], result);
            }
        }
        Console.WriteLine(highestScoringWord.word);
    }

    public static int ScoreWord(string word)
    {
        var value = 0;
        foreach(var letter in word)
        {
            if("eaionrtlsu".Contains(letter))
            {
                value += 1;
            } else if("dg".Contains(letter))
            {
                value += 2;
            } else if("bcmp".Contains(letter))
            {
                value += 3;
            } else if("fhvwy".Contains(letter))
            {
                value += 4;
            } else if("k".Contains(letter))
            {
                value += 5;
            } else if("jx".Contains(letter))
            {
                value += 8;
            } else if("qz".Contains(letter))
            {
                value += 10;
            }
        }
        return value;
    }

    public static bool CheckLetters(string wordToCheck, string letterRack)
    {
        var tempRack = letterRack;
        // for each letter in the word see if they are in the letterrack
        foreach(var letter in wordToCheck)
        {
            // if a letter is not there then the word is invalid
            if(!tempRack.Contains(letter))
                return false;

            //remove the letter from the rack so the letter cannot be used again
            tempRack = tempRack.Remove(tempRack.IndexOf(letter), 1);
        }
        //if all the letters are there then the word is valid          
        return true;
    }
}
