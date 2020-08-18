//using System;
//using System.Linq;
//using System.IO;
//using System.Text;
//using System.Collections;
//using System.Collections.Generic;
//using System.Xml.Linq;

///**
//    *BlitzProg adapts himself to the new experience system. 
//    *To stand a chance against the top end tier Codingamers,
//    *he now needs to create puzzles.
//    *
//    *BlitzProg solves his own puzzles once they get accepted
//    *to maximize experience gain, for a total of 300xp per puzzles.
//    *
 
//    *
//    *You're given the current Level and XP needed for BlitzProg to level up. 
//    *Your goal is to find out what these stats will be after N of his puzzles are approved.
// **/
//class Solution
//{
//    static void Main(string[] args)
//    {
//        int level = int.Parse(Console.ReadLine());
//        int xp = int.Parse(Console.ReadLine());
//        int N = int.Parse(Console.ReadLine());

//        N = N * 300;

//        while (N >= xp)
//        {
//            N -= xp;
//            level++;
//            xp = CalculateXp(level);
//        }
//        xp -= N;
//        /**
//         * Ashen_Undead02496
         
//        *   N = N * 300; 
//        *   while (N >= Xp) { 
//        *   N -= Xp;
//        *   Level++; 
//        *   Xp = 10 * Level * sqrt(Level); }
//        *   Xp -= N;
//        **/
//        // Write an answer using Console.WriteLine()
//        // To debug: Console.Error.WriteLine("Debug messages...");

//        Console.WriteLine(level);
//        Console.WriteLine(Math.Abs(xp));
//    }



//    /**
//     * The xp needed to reach the next level is
//     *( CurrentLevel * Sqrt(CurrentLevel) * 10 ), rounded down.
//     **/
//    public static int CalculateXp(int currentLevel) =>
//            (int)Math.Floor(currentLevel * Math.Sqrt(currentLevel) * 10);

//}