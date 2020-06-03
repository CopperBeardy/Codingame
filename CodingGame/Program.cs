using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using System.Security.Cryptography.X509Certificates;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    // https://www.codingame.com/ide/puzzle/go-competition
    static void Main(string[] args)
    {
        //TODO: loop through all lines here
        Score totalScore = new Score{scoreW = 6.5, scoreB = 0};

        string line = "....BBWW....";
        Score lineScore = GetLineScore(line);
        Console.WriteLine("W scored : " + lineScore.scoreW);
        Console.WriteLine("B scored : " + lineScore.scoreB);
        //Do the loopy thing


        // totalScore.scoreW += lineScore.scoreW;
        // totalScore.scoreB += lineScore.scoreB;
        // // show the total scores

    }

    struct Section
    {
        public int StartPos;
        public int EndPos;
        public char PlayerLetter;
    }

    struct Score {
        public double scoreW;
        public double scoreB;
    }

    public  Score GetLineScore(string LineCharacters)
    {
        int startOfSection = -1;
        string lastLetter = String.Empty;    
        int endOfSection = -1;
        Section section = new Section { StartPos = -1, EndPos = -1, PlayerLetter = 'X' };

        for (int i = 0; i < LineCharacters.Length; i++)
        {
            if (LineCharacters[i] == '.')//Start the section at the start of the line
            {
                int startCompare = i;
                section.StartPos = i;
                section.EndPos = FindEndOfSection(startCompare, LineCharacters);
                LineCharacters = FillSection(section, LineCharacters);
                lastLetter = section.PlayerLetter;
                //NO! not here, still need to compare the rest of the line 
                //break;
            }
            
            //skip to the end of that section, and start comparing again.
            lastLetter = section.PlayerLetter;
            
            i=section.EndPos +1;
            //if the end of the section was the end of the line, then i should be greater than the end index of the FOR loop. 
            //Do I need to exit FOR or, will the FOR loop take care of it automatically?

        }

        Score score = new Score { scoreW = 0, scoreB = 0 };
        for (int j = 0; j < LineCharacters.Length; j++)
        {
            if (LineCharacters[j].ToString().ToLower() == "b") {
                score.scoreB += 1;
            }
            else {//MUST be B or W after a line is transformed
                score.scoreW += 1;
            }
        }
    }
    
    //WinningChar is the player that won that section
    public string FillSection(Section section, string LineOfChars)
    {
        string transformedLine = LineOfChars;

        for(int i = section.StartPos; i < section.EndPos; i++)
        {
            LineOfChars[i] = section.PlayerLetter.ToString().ToLower;
            
        }

        return LineOfChars;
        
    }
        //!fbombCount+2
        public int FindEndOfSection(int startAt, string LineOfCharacters)
        {
            if (startAt <= LineOfCharacters.Length)
            {
                for (int j = startAt + 1; j < LineOfCharacters.Length; j++)
                {
                    //if find anything other than a dot, then the section ends with a B or W.
                    if (LineOfCharacters[j] != '.')
                    {
                        return j;
                    }
                }
            }
            return startAt;
        }
    }

    // int L = int.Parse(Console.ReadLine());
    // string[] lines = new string[L];
    // double BlackScore = 0;
    // double WhiteScore = 6.5;
    // for(int i = 0; i < L; i++)
    // {
    //     lines[i] = Console.ReadLine();
    // }

    // for (int i = 0; i < lines.Length; i++)
    // {
    //     string lastLetter = "";
    //     string line = lines[i];
    //     int firstIndexOfB = line.IndexOf("B");
    //     int firstIndexOfW = line.IndexOf("W");



    // }



    // Console.WriteLine($"BLACK : {BlackScore}");
    // Console.WriteLine($"WHITE : {WhiteScore}");
    // string winner = BlackScore > WhiteScore ? "BLACK" : "WHITE";
    // Console.WriteLine($"{winner} WINS");
    // Console.ReadLine();

    //public static string Transform(string line)
    //{

    //}



}