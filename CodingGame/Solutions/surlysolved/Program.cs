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
//class Solution
//{
//    // https://www.codingame.com/ide/puzzle/go-competition
//    static void Main(string[] args)
//    {

//        const double KOMI = 6.5;
//        Score totalScore = new Score { scoreW = KOMI, scoreB = 0 };
//        Score lineScore;

//        //---- Game One ----
//        lineScore = TestLine("....BBWW....", 6, 6);

//        totalScore.scoreW += lineScore.scoreW;
//        totalScore.scoreB += lineScore.scoreB;
//        //---- ---- ---- ----

//        //---- Game Two ---
//        lineScore = TestLine("BBBBBBWWWWWW", 6, 6);

//        totalScore.scoreW += lineScore.scoreW;
//        totalScore.scoreB += lineScore.scoreB;
//        //---- ---- ---- ----

//        // // show the total scores
//        Console.WriteLine();
//        Console.WriteLine("Game complete");
//        Console.WriteLine("W = " + totalScore.scoreW);
//        Console.WriteLine("B = " + totalScore.scoreB);

//        // ---- Pause for input
//        Console.ReadLine();
//    }

//    public static Score TestLine(string lineCharsToTest, int expectedWScore, int expectedBScore)
//    {
//        //string line = "....BBWW....";
//        Score lineScore = GetLineScore(lineCharsToTest);
//        Console.WriteLine("W scored : " + lineScore.scoreW);
//        Console.WriteLine("B scored : " + lineScore.scoreB);
//        System.Diagnostics.Debug.Assert(lineScore.scoreW == expectedWScore);
//        System.Diagnostics.Debug.Assert(lineScore.scoreB == expectedBScore);
//        //bomb out if expected results aren't returned
//        return lineScore;
//    }

//    public struct Section
//    {
//        public int StartPos;
//        public int EndPos;
//        public string PlayerLetter;
//    }

//    public struct Score
//    {
//        public double scoreW;
//        public double scoreB;
//    }

//    public static Score GetLineScore(string LineCharacters)
//    {
//        string lastLetter= "X";
//        Section section = new Section { StartPos = -1, EndPos = -1, PlayerLetter = "X" };

//        for (int i = 0; i < LineCharacters.Length; i++)
//        {

//            if (LineCharacters[i] == '.')
//            {
//                int startCompare = i;
//                section.StartPos = i;
//                section.EndPos = FindEndOfSection(startCompare, LineCharacters);
//                if (section.StartPos == 0)
//                {
//                    section.PlayerLetter = LineCharacters[section.EndPos +1].ToString().ToLower();
//                }
//                else
//                {
//                    section.PlayerLetter = lastLetter.ToLower().ToCharArray()[0].ToString();
//                }
//                LineCharacters = FillSection(section, LineCharacters);

//                //move to after the section
//                i = section.EndPos + 1;
//                //break;
//            }
//            else
//            {
//                lastLetter = LineCharacters[i].ToString();
//            }

//            //if ((i == LineCharacters.Length) && (LineCharacters[i] == '.'))
//            //{
//            //    //end of line section
//            //    section.PlayerLetter = lastLetter;
//            //    section.EndPos = i;
//            //    LineCharacters = FillSection(section, LineCharacters);
//            //}
//        }


//        Score score = new Score { scoreW = 0, scoreB = 0 };
//        for (int j = 0; j < LineCharacters.Length; j++)
//        {
//            if (LineCharacters[j].ToString().ToLower() == "b")
//            {
//                score.scoreB += 1;
//            }
//            else
//            {//MUST be B or W after a line is transformed
//                score.scoreW += 1;
//            }
//        }

//        return score;
//    }

//    //WinningChar is the player that won that section
//    public static string FillSection(Section section, string LineOfChars)
//    {
//        char[] transformedLineChars = LineOfChars.ToCharArray();

//        for (int i = section.StartPos; i <= section.EndPos; i++)
//        {
//            transformedLineChars[i] = section.PlayerLetter.ToCharArray()[0];
//            Console.WriteLine("Character " + i.ToString() + " claimed for " + section.PlayerLetter);
//            //Console.WriteLine(transformedLineChars.ToString());
//        }

//        string transformedLine = new string(transformedLineChars);
//        return transformedLine;

//    }

//    public static int FindEndOfSection(int startAt, string LineOfCharacters)
//    {
//        if (startAt <= LineOfCharacters.Length)
//        {
//            for (int j = startAt + 1; j < LineOfCharacters.Length; j++)
//            {
//                //if find anything other than a dot, then the section ends with a B or W.
//                if (LineOfCharacters[j] != '.')
//                {
//                    return j -1;
//                }
//            }
//        }
//        return LineOfCharacters.Length-1;
//    }
//}





